using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите х:");
            double x = double.Parse(Console.ReadLine()) * (Math.PI / 180.0);
            Console.Write("Введите q:");
            double q = double.Parse(Console.ReadLine());
            bool k = true;
            double cos_x = 0;
            double factorial;
            double factorial_res;

            for (double term = 9999, i=0;term>q;i++, k = !k)
            {
                factorial = i!=0 ? 2*i : 1;
                factorial_res = 1;
                
                do
                {
                    factorial_res *= factorial;
                    factorial--;
                }
                while (factorial > 1);
          
                term = Math.Pow(x, 2 * i) / factorial_res;

                if (k)
                {
                    cos_x += term;
                }
                else
                {
                    cos_x -= term;
                }
            }
            x *= (180.0 / Math.PI);
            Console.WriteLine($"Cos({x})={cos_x:0.000}"); 
        }
    }
}