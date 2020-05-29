using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSortingAlgorithms
{
    class Pyramid
    {
        private static void Swap(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }

        private static void Heapify(int[] array, int i, int N, ref long permutations, ref long comparisons)
        {
            while (2 * i + 1 < N)
            {
                int k = 2 * i + 1;
                comparisons++;
                if (2 * i + 2 < N && array[2 * i + 2] >= array[k])
                {
                    k = 2 * i + 2;
                }
                comparisons++;
                if (array[i] < array[k])
                {
                    permutations++;
                    Swap(ref array[i], ref array[k]);
                    i = k;
                }
                else
                {
                    break;
                }
            }
        }

        public static int[] Sort(int[] array, int left, int right, ref long permutations, ref long comparisons)
        {
            int N = right - left + 1;

            for (int i = right; i >= left; i--)
            {
                Heapify(array, i, N, ref permutations, ref comparisons);
            }

            while (N > 0)
            {
                Swap(ref array[left], ref array[N - 1]);
                Heapify(array, left, --N, ref permutations, ref comparisons);
            }

            return array;
        }
    }
}
