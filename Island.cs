using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace wolf_island
{
    class Island
    {
        int WolfsCounter;
        int WolfessesCounter;
        int RabbitsCounter;

        int TIMEOUT = 500;

        public int Timeout
        {
            get { return TIMEOUT; }
            set { if (value > 0 && value < 5000) TIMEOUT = value; }
        }

        bool isStarted = false;

        public bool IsStarted
        {
            get { return isStarted; }
            set { isStarted = value; }
        }


        List <Wolf> WolfsArray;
        List <Wolfess> WolfessesArray;
        List <Rabbit> RabbitsArray;

        PictureBox[,] Boxes;


        public Island(Form WinForm, int wolfsCounter, int wolfessesCounter, int rabbitsCounter, PictureBox[,] boxes)
        {
            WolfsCounter = wolfsCounter;
            WolfessesCounter = wolfessesCounter;
            RabbitsCounter = rabbitsCounter;

            Boxes = boxes;

            WolfsArray = new List<Wolf>();
            WolfessesArray = new List<Wolfess>();
            RabbitsArray = new List<Rabbit>();


            for (int i = 0; i < rabbitsCounter; i++)
            {
                RabbitsArray.Insert(i, new Rabbit(Animal.random.Next(0, 19), Animal.random.Next(0, 19)));
            }

            for (int i = 0; i < wolfsCounter; i++)
            {
                WolfsArray.Insert(i, new Wolf(Animal.random.Next(0, 19), Animal.random.Next(0, 19)));
            }

            for (int i = 0; i < wolfessesCounter; i++)
            {
                WolfessesArray.Insert(i, new Wolfess(Animal.random.Next(0, 19), Animal.random.Next(0, 19)));
            }
        }

        public void Update()
        {
       
            foreach(Rabbit rabbit in RabbitsArray.ToArray())
            {
                if(!rabbit.IsStay())
                {
                    rabbit.Walk();
                }
                else
                {
                    Console.WriteLine("Кролик залишається на місці");
                }
                if (rabbit.MakeGenearation())
                {
                    Console.WriteLine("Кролик виводить потомство");
                    RabbitsArray.Add(new Rabbit(rabbit.X, rabbit.Y));
                    RabbitsCounter++;
                }
            }
            Draw();

            foreach(Wolfess wolfess in WolfessesArray.ToArray())
            {
                if(wolfess.Fullness <= 0) 
                {
                    WolfessesArray.Remove(wolfess);
                    WolfessesCounter--;
                    Console.WriteLine($"[{wolfess.Y}:{wolfess.X}] | Вовчиця помирає від голоду");
                }
                
                Rabbit huntedRabbit = wolfess.ScanRabbits(RabbitsArray);

                if(huntedRabbit == null)
                {
                    wolfess.Walk();
                } else
                {
                    wolfess.X = huntedRabbit.X;
                    wolfess.Y = huntedRabbit.Y;
                    wolfess.HuntRabbit();
                    RabbitsArray.Remove(huntedRabbit);
                    RabbitsCounter--;
                }
            }

            foreach(Wolf wolf in WolfsArray.ToArray())
            {
                if (wolf.Fullness <= 0)
                {
                    WolfsArray.Remove(wolf);
                    WolfsCounter--;
                    Console.WriteLine($"[{wolf.Y}:{wolf.X}] | Вовк помирає від голоду");
                }
                
                Rabbit huntedRabbit = wolf.ScanRabbits(RabbitsArray);

                if (huntedRabbit == null)
                {
                    Wolfess chasedWolfess = wolf.ScanWolfess(WolfessesArray);
                    if (chasedWolfess == null)
                    {
                        wolf.Walk();
                    }
                    else
                    {
                        wolf.X = chasedWolfess.X;
                        wolf.Y = chasedWolfess.Y;

                        if(chasedWolfess.MakeGeneration())
                        {
                            WolfsArray.Add(new Wolf(chasedWolfess.X, chasedWolfess.Y));
                            WolfsCounter++;
                            Console.WriteLine($"({chasedWolfess.X}:{chasedWolfess.Y}) Народився вовк");
                        } else
                        {
                            WolfessesArray.Add(new Wolfess(chasedWolfess.X, chasedWolfess.Y));
                            WolfessesCounter++;
                            Console.WriteLine($"({chasedWolfess.X}:{chasedWolfess.Y}) Народилась вовчиця");
                        }
                    }

                }
                else
                {
                    wolf.X = huntedRabbit.X;
                    wolf.Y = huntedRabbit.Y;
                    wolf.HuntRabbit();
                    RabbitsArray.Remove(huntedRabbit);
                    RabbitsCounter--;
                }
            }
        }

        public void Draw()
        {
            PictureBox[,] tmpBoxes = Boxes;

            foreach(PictureBox box in tmpBoxes)
            {
                box.BackColor = Color.White;
            }
            
            foreach(Rabbit rabbit in RabbitsArray)
            {
               tmpBoxes[rabbit.Y, rabbit.X].BackColor = Color.Green;
            }

            foreach(Wolf wolf in WolfsArray)
            {
                tmpBoxes[wolf.Y, wolf.X].BackColor = Color.Blue;
            }

            foreach(Wolfess wolfess in WolfessesArray)
            {
                tmpBoxes[wolfess.Y, wolfess.X].BackColor = Color.Red;
            }

            Boxes = tmpBoxes;
        }

        public async void Tick(Form frm)
        {
            if(isStarted)
            {
                NumericUpDown wl = (NumericUpDown)frm.Controls.Find("wolfsCounter", true)[0];
                NumericUpDown ws = (NumericUpDown)frm.Controls.Find("wolfessCounter", true)[0];
                NumericUpDown rb = (NumericUpDown)frm.Controls.Find("rabbitsCounter", true)[0];

                wl.Value = WolfsCounter;
                ws.Value = WolfessesCounter;
                rb.Value = RabbitsCounter;

                Draw();
                Update();
                await Task.Delay(TIMEOUT);
                Tick(frm);
            }
        }

    }
}
