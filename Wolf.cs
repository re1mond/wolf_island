using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolf_island
{
    class Wolf : Animal
    {
        public double Fullness = 1;

        public Wolf(int x, int y) : base(x, y)
        {

        }

        public new void Walk()
        {
            Fullness -= 0.1;
            base.Walk();
        }

        public Rabbit ScanRabbits(List<Rabbit> rabbitsArr)
        {
            foreach (Rabbit rabbit in rabbitsArr.ToArray())
            {
                if (rabbit.X <= X + 1 && rabbit.X >= X - 1 &&
                    rabbit.Y >= Y - 1 && rabbit.Y <= Y + 1 &&
                    (rabbit.X != X && rabbit.Y != Y))
                {
                    Console.WriteLine($"[{Y}:{X}] Вовк знайшов кролика на [{rabbit.Y}:{rabbit.X}]");
                    return rabbit;
                }
            }

            return null;
        }

        public void HuntRabbit()
        {
            Fullness += 0.1;
        }

        public Wolfess ScanWolfess(List<Wolfess> wolfessArr)
        {
            foreach (Wolfess wolfess in wolfessArr.ToArray())
            {
                if (wolfess.X <= X + 1 && wolfess.X >= X - 1 &&
                    wolfess.Y >= Y - 1 && wolfess.Y <= Y + 1 &&
                    (wolfess.X != X && wolfess.Y != Y) && wolfess.ReadyRatio >= 1)
                {
                    Console.WriteLine($"[{Y}:{X}] Вовк знайшов вовчицю на [{wolfess.Y}:{wolfess.X}]");
                    return wolfess;
                }
            }

            return null;
        }
    }
}
