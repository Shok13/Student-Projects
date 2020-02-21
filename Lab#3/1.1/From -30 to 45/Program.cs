using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From__30_to_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array:");
            
            uint amount = 0;

            while (amount == 0)
            {
                try
                {
                    amount = uint.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter the correct number!");
                }
            }
             
            Random rnd = new Random();
            int[] array = new int[amount];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-30, 45);
            }

            Console.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                if (i + 1 == array.Length)
                {
                    Console.WriteLine(array[i]);
                }
                else if((i + 1) % 10 != 0)
                {
                    Console.Write($"{array[i]}\t");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }

            Console.WriteLine();
            uint cnt = 0;

            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > 0)
                {
                    cnt++;

                    if (cnt % 10 != 0)
                    {
                        Console.Write($"{array[i]}\t");
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }
    }
}
