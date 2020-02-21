using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            bool i = true;
            uint N = 0;
            while (i)
            {
                try
                {
                    N = uint.Parse(Console.ReadLine());
                    i = !i;
                }
                catch
                {
                    Console.WriteLine("Введите корректное число!");
                }
            }
            double N_lim = Math.Pow(N, 1 / 3.0);

            for (int x = 0; x <= N_lim; x++)
            {
                for (int y = 0; y <= N_lim; y++)
                {
                    for (int z = 0; z <= N_lim; z++)
                    {
                        if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N)
                        {
                            Console.WriteLine($"N={N}");
                            Console.WriteLine($"x={x,-3}y={y,-3}z={z,-3}");
                            i = true;
                        }
                    }
                }
            }

            if (i!=true)
            {
                Console.WriteLine("No such combinations!");
            }
                
        }
    }
}
