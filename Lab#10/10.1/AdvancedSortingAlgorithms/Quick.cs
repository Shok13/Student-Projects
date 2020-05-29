using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSortingAlgorithms
{
    class Quick
    {
        private static void Swap(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
        private static int Partition(int[] array, int left, int right, ref long permutations, ref long comparisons)
        {
            int pivot = array[right];

            int i = left - 1; 
            int j = right;

            while (i < j)
            {
                while (array[++i] < pivot);
                while (array[--j] > pivot)
                {
                    comparisons++;
                    if (j == left)
                    {
                        break;
                    }
                }
                comparisons++;
                if (i < j)
                {
                    permutations++;
                    Swap(ref array[i], ref array[j]);
                }
                else
                {
                    break;
                }
            }
            permutations++;
            Swap(ref array[i], ref array[right]);
            return i;
        }

        public static int[] Sort(int[] array, int left, int right, ref long permutations, ref long comparisons)
        {
            if (right <= left)
            {
                return array;
            }

            int partition = Partition(array, left, right, ref permutations, ref comparisons);
            Sort(array, left, partition - 1, ref permutations, ref comparisons);
            Sort(array, partition + 1, right, ref permutations, ref comparisons);

            return array;
        }
    }
}
