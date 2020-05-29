using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Dictionary<int, int>();
            for (int N = 1; N < 50000; N++)
            {
                double N_lim = Math.Pow(N, 1 / 3.0);
                int cnt = 0;
                for (int x = 0; x <= N_lim; x++)
                {
                    for (int y = 0; y <= N_lim; y++)
                    {
                        for (int z = 0; z <= N_lim; z++)
                        {
                            if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N)
                            {
                                cnt++;
                            }
                        }
                    }
                }
                if (cnt > 2)
                {
                    numbers.Add(N, cnt);
                }
                cnt = 0;
            }
            foreach(var key in numbers.Keys)
            {
                Console.Write(key + " ");
            }
        }
    }
}
