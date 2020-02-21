using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A_Z__12
{
    class Program
    {
        static void CheckTextArray(string text, int i)
        {
            for (int j = i; j < text.Length; j++)
            {
                if (text[j] == ' ' || text[j] == ',')
                {
                    break;
                }

                char check_digit = text[j];

                if (Char.IsDigit(check_digit) && j < text.Length - 2)
                {
                    check_digit = text[j + 1];
                    if (Char.IsDigit(check_digit))
                    {
                        char check_letter = text[j - 1];
                        if (text[j + 2] == ' ' || text[j + 2] == ',' && Char.IsLetter(check_letter))
                        {
                            for (int k = i; k < j + 2; k++)
                            {
                                if (k == j + 1)
                                {
                                    Console.WriteLine(text[k]);
                                }
                                else
                                {
                                    Console.Write(text[k]);
                                }
                            }
                        }
                    }
                    break;
                }
                else if (Char.IsDigit(check_digit) && j >= text.Length - 2)
                {
                    check_digit = text[j + 1];
                    if (Char.IsDigit(check_digit))
                    {
                        for (int k = i; k < j + 2; k++)
                        {
                            if (k == j + 1)
                            {
                                Console.WriteLine(text[k]);
                            }
                            else
                            {
                                Console.Write(text[k]);
                            }
                        }
                    }
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your text:");
            string text = Console.ReadLine();
            if (text == "check")
            {
                text = " C98,Carolina88 Johny9999,asudyasidu99, Bob123, Alex56, Except--n34, E_00";
                Console.WriteLine(text + "\n");
            }
            Console.WriteLine("Selection using an array of characters:");
            for (int i = 0; i < text.Length; i++)
            {
                char check_upper = text[i];
                if (i == 0 && Char.IsUpper(text[i]))
                {
                    CheckTextArray(text, i);
                }
                else if (i > 0 && Char.IsUpper(text[i]))
                {
                    if (text[i - 1] == ' ' || text[i - 1] == ',')
                    {
                        CheckTextArray(text, i);
                    }
                }
            }

            Console.WriteLine("\nRegexp Selection:");
            Regex rx = new Regex( @"\b[A-Z][a-z]*\d\d\b" );
            foreach (Match match in rx.Matches(text))
            {
                Console.WriteLine(match);
            } 
           
        }
    }
}
