using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your text:");
            string text = Console.ReadLine();

            char[] text_array = text.ToCharArray();
            bool check = true;

            for (int i = 0; i < text_array.Length; i++)
            {
                for (int j = 0; j < text_array.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (text_array[i] == text_array[j])
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    Console.Write($"{text_array[i]}, ");
                }
                else
                {
                    check = true;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text.IndexOf(text[i]) == text.LastIndexOf(text[i]))
                {
                    Console.Write($"{text_array[i]}, ");
                }
            }
        }
    }
}
