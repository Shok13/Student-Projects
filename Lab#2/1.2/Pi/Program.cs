using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество слагаемых для примерного вычисления числа Пи:");
            ulong number = ulong.Parse(Console.ReadLine());
            bool k = true;
            decimal d = 1m, pi = 0m;
         
            for (ulong i = 0; i<number; i++, k=!k, d+=2)
            {
                if(k)
                {
                    pi += (1 / d);
                }
                else
                {
                    pi -= (1 / d);
                }
            }

            pi *= 4;

            Console.WriteLine("Pi=" + pi);
        }
    }
}
