using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решим квадратное уравнение вида  ax^2+ bx + c = 0");
            Console.WriteLine("Для этого введите свободные коээфициенты a, b, c:");

            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;

            Console.Clear();
            Console.WriteLine($"{a}x^2+{b}x+{c}=0");

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("Уравнение имеет два корня:");
                Console.WriteLine($"x1={x1}");
                Console.WriteLine($"x2={x2}");
            }
            else if(D==0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("Уравнение имеет один корень:");
                Console.WriteLine($"x1={x1}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней:");
                Console.WriteLine(@"x1={0}+i{1}", -b / 2 * a, Math.Sqrt(Math.Abs(D)) / 2 * a);
                Console.WriteLine(@"x2={0}-i{1}", -b / 2 * a, Math.Sqrt(Math.Abs(D)) / 2 * a);
            }

        }
    }
}
