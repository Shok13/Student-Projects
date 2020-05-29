using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Bills
{
    class Counting
    {
        public static int[] Sort(int[] array, int left, int right)
        {
            int min = 0, max = 0;

            for (int i = left; i <= right; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] > max) 
                {
                    max = array[i];
                }
            }

            int bn = max - min + 1;

            int[] buckets = new int[bn];

            for (int i = left; i <= right; i++)
            {
                buckets[array[i] - min]++;
            }
              
            int idx = 0;
            for (int i = min; i <= max; i++)
            {
                for (int j = 0; j < buckets[i - min]; j++)
                {
                    array[idx++] = i;
                }
            }
            return array;
        }
    }
}
