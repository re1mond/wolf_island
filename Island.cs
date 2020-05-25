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


        Wolf[] WolfsArray;
        Wolfess[] WolfessesArray;
        Rabbit[] RabbitsArray;

        PictureBox[,] Boxes;


        public Island(Form WinForm, int wolfsCounter, int wolfessesCounter, int rabbitsCounter, PictureBox[,] boxes)
        {
            WolfsCounter = wolfsCounter;
            WolfessesCounter = wolfessesCounter;
            RabbitsCounter = rabbitsCounter;

            Boxes = boxes;

            WolfsArray = new Wolf[WolfsCounter];
            WolfessesArray = new Wolfess[WolfessesCounter];
            RabbitsArray = new Rabbit[RabbitsCounter];


            for (int i = 0; i < rabbitsCounter; i++)
            {
                RabbitsArray[i] = new Rabbit(Animal.random.Next(0, 19), Animal.random.Next(0, 19));
            }

            for (int i = 0; i < wolfsCounter; i++)
            {
                WolfsArray[i] = new Wolf(Animal.random.Next(0, 19), Animal.random.Next(0, 19));
            }

            for (int i = 0; i < wolfessesCounter; i++)
            {
                WolfessesArray[i] = new Wolfess(Animal.random.Next(0, 19), Animal.random.Next(0, 19));
            }
        }

        public void Update()
        {
       
            foreach(Rabbit rabbit in RabbitsArray)
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
                    Array.Resize(ref RabbitsArray, RabbitsCounter + 1);
                    RabbitsArray[RabbitsCounter++] = new Rabbit(rabbit.X, rabbit.Y);
                }
            }
            Draw();

            foreach(Wolfess wolfess in WolfessesArray)
            {
                /*foreach (Rabbit rabbit in RabbitsArray)
                {
                    if (rabbit.X <= wolfess.X + 1 && rabbit.X >= wolfess.X - 1 && 
                        rabbit.Y >= wolfess.Y - 1 && rabbit.Y <= wolfess.Y + 1 && 
                        (rabbit.X != wolfess.X && rabbit.Y != wolfess.Y))
                    {
                        //wolfess.X = rabbit.X;
                        //wolfess.Y = rabbit.Y;
                        Console.WriteLine($"[{wolfess.Y}:{wolfess.X}] Вовчиця знайшла кролика");
                    }
                }*/
                Rabbit huntedRabbit = wolfess.ScanRabbits(RabbitsArray);

                if(huntedRabbit == null)
                {
                    wolfess.Walk();
                } else
                {
                    wolfess.X = huntedRabbit.X;
                    wolfess.Y = huntedRabbit.Y;
                    wolfess.HuntRabbit();
                    RabbitsArray = Arr.Remove(RabbitsArray, Array.IndexOf(RabbitsArray, huntedRabbit));
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

        public async void Tick()
        {
            if(isStarted)
            {
                Draw();
                Update();
                await Task.Delay(TIMEOUT);
                Tick();
            }
        }

    }
}
