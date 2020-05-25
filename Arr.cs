using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolf_island
{
    class Arr
    {
        public static Rabbit[] Remove(Rabbit[] arr, int index)
        {
            Rabbit[] newArray = new Rabbit[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                if (i < index)
                {
                    newArray[i] = arr[i];
                }
                else if (i > index)
                {
                    newArray[i - 1] = arr[i];
                }
            }

            return newArray;
        }
    }
}
