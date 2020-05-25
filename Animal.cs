using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolf_island
{
    class Animal
    {
        int x;
        int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value >= 0 && value < 20)
                {
                    x = value;
                } else
                {
                    throw new Exception("Координата X не может выходить за граници [0,20]");
                }
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value >= 0 && value < 20)
                {
                    y = value;
                }
                else
                {
                    throw new Exception("Координата Y не может выходить за граници [0,20]");
                }
            }
        }

        public static Random random = new Random();

        public Animal(int x, int y)
        {
            X = x;
            Y = y;
        }

        private void MoveUp()
        {
            y--;
        }

        private void MoveDown()
        {
            y++;
        }

        private void MoveLeft()
        {
            x--;
        }

        private void MoveRight()
        {
            x++;
        }

        public int Walk()
        {
            if (x > 0 && x < 19 && y > 0 && y < 19)
            {
                int direction = random.Next(1, 9);
                if (direction == 1) { MoveUp(); MoveLeft(); return 0; }
                if (direction == 2) { MoveUp(); return 0; }
                if (direction == 3) { MoveUp(); MoveRight(); return 0; }
                if (direction == 4) { MoveLeft(); return 0; }
                if (direction == 5) { MoveRight(); return 0; }
                if (direction == 6) { MoveDown(); MoveLeft(); return 0; }
                if (direction == 7) { MoveDown(); return 0; }
                if (direction == 8) { MoveDown(); MoveRight(); return 0; }
            }
            else if (x == 0 && y == 0)
            {
                int direction = random.Next(1, 4);
                if (direction == 1) { MoveRight(); return 0; }
                if (direction == 2) { MoveDown(); return 0; }
                if (direction == 3) { MoveDown(); MoveRight(); return 0; }
            }
            else if (x > 0 && x < 19 && y == 0)
            {
                int direction = random.Next(1, 6);
                if (direction == 1) { MoveLeft(); return 0; }
                if (direction == 2) { MoveRight(); return 0; }
                if (direction == 3) { MoveDown(); MoveLeft(); return 0; }
                if (direction == 4) { MoveDown(); return 0; }
                if (direction == 5) { MoveDown(); MoveRight(); return 0; }
            }
            else if (x == 19 && y == 0)
            {
                int direction = random.Next(1, 4);
                if (direction == 1) { MoveLeft(); return 0; }
                if (direction == 2) { MoveDown(); MoveLeft(); return 0; }
                if (direction == 3) { MoveDown(); return 0; }
            }
            else if (x == 19 && y > 0 && y < 19)
            {
                int direction = random.Next(1, 6);
                if (direction == 1) { MoveUp(); return 0; }
                if (direction == 2) { MoveLeft(); MoveUp(); return 0; }
                if (direction == 3) { MoveLeft(); return 0; }
                if (direction == 4) { MoveLeft(); MoveDown(); return 0; }
                if (direction == 5) { MoveDown(); return 0; }
            }
            else if (x == 19 && y == 19)
            {
                int direction = random.Next(1, 4);
                if (direction == 1) { MoveUp(); return 0; }
                if (direction == 2) { MoveUp(); MoveLeft(); return 0; }
                if (direction == 3) { MoveLeft(); return 0; }
            }
            else if (x < 19 && x > 0 && y == 19)
            {
                int direction = random.Next(1, 6);
                if (direction == 1) { MoveUp(); MoveLeft(); return 0; }
                if (direction == 2) { MoveUp(); return 0; }
                if (direction == 3) { MoveRight(); MoveUp(); return 0; }
                if (direction == 4) { MoveLeft(); return 0; }
                if (direction == 5) { MoveRight(); return 0; }
            }
            else if (x == 19 && y == 19)
            {
                int direction = random.Next(1, 4);
                if (direction == 1) { MoveUp(); return 0; }
                if (direction == 2) { MoveUp(); MoveLeft(); return 0; }
                if (direction == 3) { MoveLeft(); return 0; }
            }
            else if (x == 0 && y > 0 && y < 19)
            {
                int direction = random.Next(1, 6);
                if (direction == 1) { MoveUp(); return 0; }
                if (direction == 2) { MoveUp(); MoveRight(); return 0; }
                if (direction == 3) { MoveRight(); return 0; }
                if (direction == 4) { MoveDown(); MoveRight(); return 0; }
                if (direction == 5) { MoveDown(); return 0; }
            }
            else if (x == 0 && y == 19)
            {
                int direction = random.Next(1, 4);
                if (direction == 1) { MoveUp(); return 0; }
                if (direction == 2) { MoveUp(); MoveRight(); return 0; }
                if (direction == 3) { MoveRight(); return 0; }
            }
            else
            {
                return 0;
            }
            return 0;
        }
    }
}
