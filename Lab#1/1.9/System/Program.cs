using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решим систему уравнений вида: \na1x + b1y + с1z = d1 \na2x + b2y + с2z = d2 \na3x + b3y + с3z = d3");
            Console.WriteLine("Для этого введите 9 коэффициентов и 3 свободных члена:");



            Console.Write("a1=");
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b1=");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c1=");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("d1=");
            double d1 = Convert.ToDouble(Console.ReadLine());



            Console.Write("a2=");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b2=");
            double b2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c2=");
            double c2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("d2=");
            double d2 = Convert.ToDouble(Console.ReadLine());



            Console.Write("a3=");
            double a3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b3=");
            double b3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c3=");
            double c3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("d3=");
            double d3 = Convert.ToDouble(Console.ReadLine());



            double A = a1 * b2 * c3 + a3 * b1 * c2 + a2 * b3 * c1 - a3 * b2 * c1 - a2 * b1 * c3 - a1 * b3 * c2;


            double Ax = d1 * b2 * c3 + d3 * b1 * c2 + d2 * b3 * c1 - d3 * b2 * c1 - d2 * b1 * c3 - d1 * b3 * c2;
            double Ay = a1 * d2 * c3 + a3 * d1 * c2 + a2 * d3 * c1 - a3 * d2 * c1 - a2 * d1 * c3 - a1 * d3 * c2;
            double Az = a1 * b2 * d3 + a3 * b1 * d2 + a2 * b3 * d1 - a3 * b2 * d1 - a2 * b1 * d3 - a1 * b3 * d2;


            double x = Ax / A;
            double y = Ay / A;
            double z = Az / A;


            Console.Clear();

            Console.WriteLine($"{a1}x + {b1}y + {c1}z = {d1} \n{a2}x + {b2}y + {c2}z = {d2} \n{a3}x + {b3}y + {c3}z = {d3} \nx={x} y={y} z={z}");
            Console.ReadKey();
            
        }
    }
}
