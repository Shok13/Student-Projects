using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_operations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter X:");
            double x = double.Parse(Console.ReadLine());

            double my_res = x * x * (3 * x - 2) * (x - 1) - x + 7;
            double true_res = 3 * x * x * x * x - 5 * x * x * x + 2 * x * x - x + 7;
            double TrueRes = 3 * Math.Pow(x, 4) - 5 * Math.Pow(x, 3) + 2 * Math.Pow(x, 2) - x + 7;

            Console.WriteLine("Result={0}; {1}; {2}", my_res, true_res, TrueRes);
            Console.ReadKey();

        }
    }
}
