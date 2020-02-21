using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_nd_ind
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10; i < 100; i++)
            {
                if (i % 4 != 0 && (i%10==4||i/10==4))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
