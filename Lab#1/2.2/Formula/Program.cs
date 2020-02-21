using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, b = 7, a=9; 

            double w = Math.Sqrt(Math.Pow(x,2) + b) - Math.Pow(b, 2) * Math.Pow(Math.Sin(x + a), 3) / x; // x^2>=-b; x/=/0

            double y = Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) - x / Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)); // a^2+b^2/=/0

            Console.WriteLine($"{w} {y}");
            Console.ReadKey();

        }
    }
}
