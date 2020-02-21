using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 1, f2 = 1, cnt = 0;
            bool k = true;
            while(f1 <= 9999 && f2 <= 9999)
            {
                if (k)
                {
                    f2 += f1;
                }
                else
                {
                    f1 += f2;
                }
                if (k && f1 >= 1000 && f1 <= 9999)
                {
                    cnt++;
                }
                else if (f1 >= 1000 && f1 <= 9999)
                {
                    cnt++;
                }

                k = !k;
            }
            Console.WriteLine(cnt);
        }
    }
}
