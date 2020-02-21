using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_ind
{
    class Program
    {
        static void SecondWay(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i].IndexOf(words[i][j]) != words[j].LastIndexOf(words[i][j]))
                    {
                        if ((j != words[i].Length - 1) && (words[i][j] == words[i][j + 1]))
                        {
                            words[i] = "";
                        }
                    }
                }
            }
            string text_seond_way = String.Join(" ", words);
            string[] crutch = text_seond_way.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            text_seond_way = String.Join(" ", crutch);
            Console.WriteLine(text_seond_way);
        }
        static char[] DeleteWords(string text)
        {
            int start_letter = 0;
            char[] text_array = text.ToCharArray();
            for (int i = 0; i < text_array.Length; i++)
            {
                if (text_array[i] == ' ')
                {
                    for (int j = start_letter, last_letter = i - 1; j <= last_letter; j++)
                    {
                        if (j > 0 && text[j] == text[j - 1])
                        {
                            for (int k = start_letter; k <= last_letter; k++)
                            {
                                text_array[k] = ' ';
                            }
                        }
                    }
                    if (i != text.Length - 1)
                    {
                        start_letter = i + 1;
                    }
                }
            }
            return text_array;
        }
        //static char[] ShiftArray(char[] array, int start_pos)
        //{
        //    for (int j = start_pos; j < array.Length; j++)
        //    {
        //        if (array[j] != ' ')
        //        {
        //            for (int k = 0; k < 1; k++)
        //            {
        //                char tmp = array[start_pos];
        //                for (int n = j; n < array.Length; n++)
        //                {
        //                    if (n != (array.Length - 1))
        //                    {
        //                        array[n] = array[n + 1];
        //                    }
        //                    else
        //                    {
        //                        array[array.Length - 1] = tmp;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return array;
        //}

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text == "check")
            {
                text = "I can't sleep all parrot carrot tooth day";
                Console.Clear();
                Console.WriteLine(text);
            }
            SecondWay(text);
            //First way____________________________________________________________________________________________________________________
            char[] text_array = DeleteWords(text);
            for (int i = 0; i < text_array.Length; i++)
            {
                if ((i > 0 && i != text_array.Length - 1) && (text_array[i] == ' ' && text_array[i - 1] == ' '))
                {
                    for (int j = i + 1; j < text_array.Length; j++)
                    {
                        if (text_array[j] != ' ')
                        {
                            for (int k = 0; k < text_array.Length; k++)
                            {
                                char tmp = text_array[i];
                                for (int n = i; n < text_array.Length; n++)
                                {
                                    if (n != (text_array.Length - 1))
                                    {
                                        text_array[n] = text_array[n + 1];
                                    }
                                    else
                                    {
                                        text_array[text_array.Length - 1] = tmp;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            string text_first_way = new string(text_array);
            Console.WriteLine(text_first_way);
        }
        //THE BEST AND EASYEST WAY IN THE WORLD
        //Regex rx = new Regex(@"\b\w*(\w)\1\w*\b");
        //text = rx.Replace(text, "");
        //Console.WriteLine(text);
    }
}
