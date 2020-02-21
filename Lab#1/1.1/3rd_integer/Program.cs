using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x = 26.8345344;

            int x1 = (int)( x * 10 );
            int x2 = (int)(x) * 10;

            int d = x1 - x2;

            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}
