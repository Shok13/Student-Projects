using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Two_operands_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string equation = Console.ReadLine();
            Regex rx = new Regex(@"-?\d+");

            MatchCollection numbers = rx.Matches(equation);

            int num1 = Convert.ToInt32(numbers[0].Value);
            int num2 = Convert.ToInt32(numbers[1].Value);
            int num3 = Convert.ToInt32(numbers[2].Value);

            Console.WriteLine($"{num1}\n{num2}\n{num3}\n");

            // or 

            int[] array = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                array[i] = Convert.ToInt32(numbers[i].Value);
            }

            foreach(int x in array)
            {
                Console.WriteLine(x);
            }
        }
    }
}
