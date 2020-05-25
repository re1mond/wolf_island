using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolf_island
{
    class Rabbit : Animal
    {
        public Rabbit(int x, int y) : base(x, y)
        {

        }

        public bool IsStay()
        {
            if (random.Next(1, 10) == 9) {
                return true;
            }
            return false;
        }

        public bool MakeGenearation()
        {
            if (random.Next(1, 6) == 5)
            {
                return true;
            }
            return false;
        }
    }
}
