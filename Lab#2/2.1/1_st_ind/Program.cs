using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_st_ind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());
            int number;
            if (x > -10 && x < 10)
            {
                if (x > 0)
                {
                    number = 1;
                    Console.WriteLine(number);
                }
                else
                {
                    number = 1;
                    Console.WriteLine("NEG");
                    Console.WriteLine(number);
                }
            }
            else if (x > -100 && x < 100)
            {
                if (x > 0)
                {
                    number = 2;
                    Console.WriteLine(number);
                }
                else
                {
                    number = 2;
                    Console.WriteLine("NEG");
                    Console.WriteLine(number);
                }
            }
            else if (x > -1000 && x < 1000)
            {
                if (x > 0)
                {
                    number = 3;
                    Console.WriteLine(number);
                }
                else
                {
                    number = 3;
                    Console.WriteLine("NEG");
                    Console.WriteLine(number);
                }
            }
            else
            {
                if (x > 0)
                {
                    Console.WriteLine("BIG");
                }
                else
                {
                    Console.WriteLine("NEG");
                    Console.WriteLine("BIG");
                }
            }
        }
    }
}
