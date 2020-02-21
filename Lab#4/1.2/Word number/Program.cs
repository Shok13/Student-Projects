using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Word_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your sentence:");
            string sentence = Console.ReadLine();

            if(sentence == "check")
            {
                sentence = "Донецк – прекрасный город, но домой хочется больше.";
            }
    
            if (sentence[sentence.Length - 1] != '.')
            {
                sentence = sentence + '.';
            }

            char[] sentence_array = sentence.ToCharArray();
            int number = 0;

            for (int i = 0; i < sentence_array.Length; i++)
            {
                if (i == sentence_array.Length - 1)
                {
                    Console.WriteLine($"({++number}).");
                    break;
                }

                if (Char.IsLetter(sentence_array[i]) && (sentence_array[i + 1] == ' ' || sentence_array[i + 1] == ',' || sentence_array[i + 1] == '-'))
                {
                    Console.Write($"{sentence_array[i]}({++number})");
                }
                else
                {
                    Console.Write(sentence_array[i]);
                }
            }


            number = 0;
            int separator = 0;

            for (int i = 0; ; i = separator)
            {
                separator = sentence.IndexOfAny(new char[] { ' ', ',', '-' }, i + 1);
                char check = sentence[separator - 1];
                if (Char.IsLetter(check))
                {
                    sentence = sentence.Insert(separator, $"({++number})");
                }
                if (separator == sentence.LastIndexOfAny(new char[] { ' ', ',', '-' }))
                {
                    sentence = sentence.Insert(sentence.Length - 1, $"({++number})");
                    break;
                }

            }
            Console.WriteLine(sentence);

        }
    }
}
