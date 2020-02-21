using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_ind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;

            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > average)
                {
                    cnt++;
                }
            }
            
            Console.WriteLine(cnt);
        }
    }
}
