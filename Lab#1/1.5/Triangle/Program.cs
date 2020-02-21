using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first leg: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second leg: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int s = (a * b) / 2;
            double p = a + b + Math.Sqrt(a * a + b * b);

            Console.WriteLine("Area of a triangle=" + s);
            Console.WriteLine("Triangle perimeter =" + p);
            Console.ReadKey();



        }
    }
}
