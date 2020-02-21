using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven_strings
{
    public static class StringExtensions
    {
        public static bool Contains(this String str, String substring,
                                    StringComparison comp)
        {
            if (substring == null)
                throw new ArgumentNullException("substring",
                                             "substring cannot be null.");
            else if (!Enum.IsDefined(typeof(StringComparison), comp))
                throw new ArgumentException("comp is not a member of StringComparison",
                                         "comp");

            return str.IndexOf(substring, comp) >= 0;
        }
    }
    class Program
    {
        
        static int minIterative(int[] array)
        {
            int min = array[0];
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    number = i;
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            string[] array_of_strings = new string[7];

            for (int i = 0; i < array_of_strings.Length; i++)
            {
                array_of_strings[i] = Console.ReadLine();
            }
            if (array_of_strings[0] == "check")
            {
                array_of_strings[0] = "text.Com, ";
                array_of_strings[1] = "domain.com.ru ";
                array_of_strings[2] = "steam.comon";
                array_of_strings[3] = "sdfjksdhf.qweiiq.cOM  ewqe  qweqwb   ";
                array_of_strings[4] = ".com.com";
                array_of_strings[5] = ".comm";
                array_of_strings[6] = "intheend.comm, qwqwd ";
                Console.Clear();
                foreach (string sentence in array_of_strings)
                {
                    Console.WriteLine(sentence);
                }
            }
            
            //First way_____________________________________________________________________________________________________________
            Console.WriteLine("\nString as an array of characters:");
            int cnt = 0;
            int[] array_of_spaces = new int[7];
            for (int i = 0; i < array_of_strings.Length; i++)
            {
                for (int j = 0; j < array_of_strings[i].Length; j++)
                {
                    if (array_of_strings[i][j] == ' ')
                    {
                        cnt++;
                    }
                    if (j < array_of_strings[i].Length - 3)
                    {
                        if (array_of_strings[i][j] == '.')
                        {
                            if (array_of_strings[i][j + 1] == 'c' || array_of_strings[i][j + 1] == 'C')
                            {
                                if (array_of_strings[i][j + 2] == 'o' || array_of_strings[i][j + 2] == 'O')
                                {
                                    if (array_of_strings[i][j + 3] == 'm' || array_of_strings[i][j + 3] == 'M')
                                    {
                                        if (j == array_of_strings[i].Length - 4)
                                        {
                                            Console.WriteLine(array_of_strings[i]);
                                        }
                                        else
                                        {
                                            if (array_of_strings[i][j + 4] == ' ' || array_of_strings[i][j + 4] == ',')
                                            {
                                                Console.WriteLine(array_of_strings[i]);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                array_of_spaces[i] = cnt;
                cnt = 0;
            }
            
            cnt = minIterative(array_of_spaces);
            
            Console.WriteLine($"\nLine number with the least number of spaces = {cnt}");
            
            //Second way____________________________________________________________________________________________________________
            cnt = 0;
            Array.Clear(array_of_spaces, 0, 7);
            Console.WriteLine("\nString class method:");
            int space_number = 0;
            StringComparison IgnoreCase = StringComparison.OrdinalIgnoreCase;
            for (int i = 0; i < array_of_strings.Length; i++)
            {
                if (array_of_strings[i].Contains(".com ", IgnoreCase) || array_of_strings[i].Contains(".com,", IgnoreCase) ||
                    array_of_strings[i].EndsWith(".com", IgnoreCase))
                {
                    Console.WriteLine(array_of_strings[i]);
                }
                space_number = array_of_strings[i].IndexOf(' ');
                if (array_of_strings[i][0]==' ')
                {
                    cnt++;
                }
                if (space_number > 0)
                    space_number--;
                for (int j = 0; j < array_of_strings[i].Length; j++)
                {
                    
                    space_number = array_of_strings[i].IndexOf(' ', space_number + 1);
                    if (space_number == -1)
                    {
                        break;
                    }
                    if (space_number > 0)
                    {
                        array_of_spaces[i] = ++cnt;
                    }
                    j = space_number;
                }
                space_number = 0;
                cnt = 0;
            }
            cnt = minIterative(array_of_spaces);
            Console.WriteLine($"\nLine number with the least number of spaces = {cnt}");
        }
    }
}
