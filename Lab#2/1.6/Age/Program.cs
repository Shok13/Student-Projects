using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());
            if (N > 0 && N <= 100)
            {
  
                if (N >= 5 && N <= 20)
                {
                    Console.WriteLine($"{N} лет");
                }
                else if (N % 10 == 1)
                {
                    Console.WriteLine($"{N} год");
                }
                else if (N % 10 >= 2 && N % 10 <= 4)
                {
                    Console.WriteLine($"{N} года");
                }
                else if (N % 10 >= 5 || N % 10 == 0)
                {
                    Console.WriteLine($"{N} лет");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели некорректный возраст, попробуйте снова");
            }
        }
    }
}
