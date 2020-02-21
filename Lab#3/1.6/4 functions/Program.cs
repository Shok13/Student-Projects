using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_functions
{
    class Program
    {
        static int sumIterative(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int sumRecursive(int[] array, int Length)
        {
            if (Length > 0)
            {
                return array[Length - 1] + sumRecursive(array, Length - 1);
            }
            else
            {
                return 0;
            }
        }
        static int minIterative(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int minRecursive(int[] array, int Length)
        {
            if(Length <= 0)
            {
                return Int32.MaxValue;
            }
            return Math.Min(array[Length - 1], minRecursive(array, Length - 1));
        }
        static void Main(string[] args)
        {
            int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sumIter = sumIterative(array);
            Console.WriteLine(sumIter);

            int minIter = minIterative(array);
            Console.WriteLine(minIter);

            int sumRec = sumRecursive(array, array.Length);
            Console.WriteLine(sumRec);

            int minRec = minRecursive(array, array.Length);
            Console.WriteLine(minRec);
        }
    }
}
