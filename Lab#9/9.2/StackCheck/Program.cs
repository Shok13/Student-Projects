using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter expression:");
            var expression = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            var isCorrect = true;
            foreach (var sign in expression)
            {
                if (sign == '(')
                {
                    stack.Push(sign);
                }
                else if (sign == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        isCorrect = false;
                        Console.WriteLine("Invalid expression");
                    }
                }
            }
            if (stack.Count == 0 && isCorrect)
            {
                Console.WriteLine("True expression");
            }
            else
            {
                Console.WriteLine("Invalid expression");
            }
        }
    }
}
