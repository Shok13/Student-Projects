using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_order
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            if(sentence == "check")
            {
                sentence = "Сегодня хороший день.";
                Console.WriteLine(sentence);
            }
            sentence = sentence.Trim().ToLower();
            if (sentence[sentence.Length - 1] != '.')
            {
                sentence += '.';
            }
            


            //First way__________________________________________________________________________________________________________

            int[] reverse_order = new int[sentence.Length];
            int start_pos = reverse_order.Length - 2, first_letter = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if ((sentence[i] == ' ' || sentence[i] == '.')) //((sentence[i] == ' ' && Char.IsLetter(sentence[i - 1])) || sentence[i] == '.' && Char.IsLetter(sentence[i - 1]))
                {
                    for (int j = start_pos, curr_letter = i - 1; curr_letter >= first_letter; j--, curr_letter--)
                    {
                        reverse_order[j] = curr_letter;
                        start_pos = j - 2;
                        if (j > 0)
                            reverse_order[j - 1] = i;
                    }
                    first_letter = i + 1;
                }
            }
            reverse_order[reverse_order.Length - 1] = reverse_order.Length - 1;
            char[] char_array = new char[reverse_order.Length];

            for (int i = 0; i < reverse_order.Length; i++)
            {
                char_array[i] = sentence[reverse_order[i]];
            }
            char_array[0] = Char.ToUpper(char_array[0]);
            string reverse_sentence = new string(char_array);
            Console.WriteLine(reverse_sentence);

            //Second way_________________________________________________________________________________________________________

            string[] words = sentence.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder new_sentence = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    new_sentence.Append($"{words[i]}.");
                }
                else
                {
                    new_sentence.Append($"{words[i]} ");
                }
            }
            new_sentence.Replace(new_sentence[0], Char.ToUpper(new_sentence[0]), 0, 1);
            Console.WriteLine(new_sentence.ToString());
        }
    }
}
