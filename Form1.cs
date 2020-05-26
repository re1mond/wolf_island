using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wolf_island
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[,] SquaresArr = new PictureBox[20, 20];
        Island island;

        int PreferTimeout = 500;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create island
            int offsetX = 5;
            int OffsetY = 5;
            for (int i = 0; i < 20; i++)
            {
                for(int q = 0; q < 20; q++)
                {
                    var picture = new PictureBox
                    {
                        Name = $"square({q},{i})",
                        Size = new Size(25, 25),
                        Location = new Point(25 * q + offsetX, 25 * i + OffsetY),
                        BackColor = Color.White,
                    };
                    int x = 5 * (q * 25);
                    int y = 5 * (i + 25);
                    offsetX += 5;
                    SquaresArr[i, q] = picture;
                    this.Controls.Add(picture);
                }
                offsetX = 5;
                OffsetY += 5;
            }

            wolfsCounter.Value = 5;
            wolfessCounter.Value = 5;
            rabbitsCounter.Value = 5;

            stopBtn.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timeoutLabel.Text = $"{1000 - trackBar1.Value * 100} мс";

            if (island == null)
            {
                PreferTimeout = 1000 - trackBar1.Value * 100;
            } else
            {
                island.Timeout = 1000 - trackBar1.Value * 100;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(island == null)
            {
                island = new Island(this, 
                                    (int)wolfsCounter.Value, 
                                    (int)wolfessCounter.Value, 
                                    (int)rabbitsCounter.Value,
                                    SquaresArr
                                    );
                island.Timeout = PreferTimeout;
            }
            island.IsStarted = true;
            island.Tick(this);
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            island.IsStarted = false;
            startBtn.Enabled = true;
        }
    }
}

// TODO:
// ✔ кролик с вероятностью 8/9 ходит в случайном направлении
// ✔ с вероятностью 0,2 выводят потомство
// ✔ волчица сканирует соседние квадрты на кроликов
// ✔ если находит то нападет, получает 1 ОЧКО
// ✔ если нет с каждым ходом теряет 0.1 ОЧКА
// ✔ волк сканит на кроликов
// ✔   - нападает
// ✔ волк сканит на волчиц
// ✔   - выводят потомство
// ✔ просто ходит


/*
Вовчий острів (Ван Тассел Д. Стиль, розробка, ефективність,
налагодження й випробування програм. - М.: Мир, 1981). Вовчий острів
розміром 20х20 заселений дикими кроликами, вовками й вовчицями. Є по
кілька представників кожного виду. Кролики досить нерозумні: у кожний
момент часу вони з однаковою ймовірністю 1/9 пересуваються в один з
восьми сусідніх квадратів (за винятком ділянок, обмежених береговою
лінією) або просто сидять нерухомо. Кожний кролик з імовірністю 0,2
перетворюється у двох кроликів. Кожна вовчиця пересувається
випадковим чином, поки в одному із сусідніх восьми квадратів не
виявиться кролик, за яким вона полює. Якщо вовчиця й кролик
виявляються в одному квадраті, вовчиця з’їдає кролика й одержує одне
очко. А якщо ні, то вона втрачає 0,1 очка. Вовки й вовчиці з нульовою
кількістю очків умирають. У початковий момент часу всі вовки й вовчиці
мають 1 очко. Вовк поводиться подібно до вовчиці доти, поки в сусідніх
квадратах не зникнуть усі кролики; тоді, якщо вовчиця перебуває в
одному з восьми прилеглих квадратів, вовк женеться за нею. Якщо вовк і
вовчиця виявляться в одному квадраті й там немає кролика, якого
потрібно з’їсти, вони роблять потомство випадкової статі.
Запрограмувати передбачувану екологічну модель і поспостерігати за
зміною популяції протягом деякого періоду часу. (120 балів)
 */
