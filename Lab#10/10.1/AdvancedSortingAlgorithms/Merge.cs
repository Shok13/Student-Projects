using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSortingAlgorithms
{
    class Merge
    {
        private static void Merge_(int[] array, int left, int mid, int right, ref long comparisons, ref long permutations)
        {
            int[] temp = new int[right - left + 1];
            int i = left;
            int j = mid + 1;
            int k = 0;

            for (k = 0; k < temp.Length; k++)
            {
                comparisons++;
                if (i > mid)
                {
                    permutations++;
                    temp[k] = array[j++];
                }
                else if (j > right)
                {
                    permutations++;
                    temp[k] = array[i++];
                }
                else
                {
                    permutations++;
                    comparisons++;
                    temp[k] = (array[i] < array[j]) ? array[i++] : array[j++];
                }
            }
            k = 0;
            i = left;
            while (k < temp.Length && i <= right)
            {
                array[i++] = temp[k++];
            }
        }

        public static int[] Sort(int[] array, int left, int right,ref long permutations,ref long comparisons)
        {
            if (right <= left)
            {
                return array;
            }

            int mid = (left + right) / 2;
            Sort(array, left, mid, ref permutations, ref comparisons);
            Sort(array, mid + 1, right, ref permutations, ref comparisons);
            Merge_(array, left, mid, right, ref comparisons, ref permutations);
            return array;
        }
    }
}
