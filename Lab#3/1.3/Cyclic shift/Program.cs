using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclic_shift
{
    class Program
    {
        static void ShowArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            ShowArray(array);

            int k = 1;
            for (int i = 0; i < k; i++)
            {
                int tmp = array[0];
                for (int j = 0; j < array.Length; j++)
                {
                    if (j != (array.Length - 1))
                    {
                        array[j] = array[j + 1];
                    }
                    else
                    {
                        array[array.Length - 1] = tmp;
                    }
                }   
            }

            ShowArray(array);
        }
    }
}
