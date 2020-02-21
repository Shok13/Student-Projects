using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {

            uint h = 11;
            decimal m = 59m;
            decimal s = 59m;

            decimal sum = (h + m / 60 + s / 3600);
            decimal angle = sum * 30;

            Console.WriteLine("Angle="+angle);
            Console.ReadKey();
        }
    }
}
