using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolf_island
{
    class Wolfess : Animal 
    {
        public double Fullness = 1;
        public double ReadyRatio = 0;

        public Wolfess(int x, int y) : base(x, y)
        {

        }

        public new void Walk()
        {
            base.Walk();
            Fullness -= 0.1;
            ReadyRatio += 0.1;
        }

        public bool MakeGeneration()
        {
            ReadyRatio = 0;
            if(random.Next(1,11) > 5)
            {
                return true;
            }
            return false;
        }

        public Rabbit ScanRabbits(List<Rabbit> rabbitsArr)
        {
            foreach (Rabbit rabbit in rabbitsArr.ToArray())
            {
                    if (rabbit.X <= X + 1 && rabbit.X >= X - 1 &&
                        rabbit.Y >= Y - 1 && rabbit.Y <= Y + 1 &&
                        (rabbit.X != X && rabbit.Y != Y))
                    {
                        Console.WriteLine($"[{Y}:{X}] Вовчиця знайшла кролика на [{rabbit.Y}:{rabbit.X}]");
                        return rabbit;
                    }
            }

            return null;
        }

        public void HuntRabbit()
        {
            Fullness += 0.1;
        }
    }
}
