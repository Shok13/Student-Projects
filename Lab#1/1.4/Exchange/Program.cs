using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 55, y = -77;

            x = x + y;
            y = x - y;
            x = x - y; 

            Console.WriteLine("{0}, {1}", x, y);
            Console.ReadKey();
        }
    }
}
