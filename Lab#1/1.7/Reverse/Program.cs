using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x:");
            string number = Console.ReadLine();
            int x = int.Parse(number);

            int x1 = x / 100;
            int x2 = x / 10 - x1*10;
            int x3 = x - (x1 * 100 + x2 * 10);

            int reversed = x3 * 100 + x2 * 10 + x1;

            Console.WriteLine("Reversed:"+reversed);
            Console.ReadKey();


        }
    }
}
