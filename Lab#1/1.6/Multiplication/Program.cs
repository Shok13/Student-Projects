using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x:");
            string number = Console.ReadLine();
            int x = int.Parse(number);

            int x1 = x / 1000;
            int x2 = x / 100 - x1 * 10;
            int x3 = x / 10 - (x1 * 100 + x2 * 10);
            int x4 = x - (x1 * 1000 + x2 * 100 + x3 * 10);

            int res = x1 * x2 * x3 * x4;

            Console.WriteLine("Result:" + res);
            Console.ReadKey();

        }
    }
}
