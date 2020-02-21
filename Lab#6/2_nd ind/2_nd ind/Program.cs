using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_nd_ind
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("D:\\Projects\\Lab#6\\2_nd ind\\text.dat", append: false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(Console.ReadLine());
                }
            }
            int line_counter = 0;

            using (StreamReader sr = new StreamReader("D:\\Projects\\Lab#6\\2_nd ind\\text.dat"))
            {
                using (StreamWriter sw = new StreamWriter("D:\\Projects\\Lab#6\\2_nd ind\\new_text.dat"))
                {
                    string sum_line = string.Empty;
                    while (sr.Peek() != -1)
                    {
                        string line = sr.ReadLine();
                        if (line.Length > 3)
                        {
                            if (sum_line.Length > 0)
                            {
                                sw.WriteLine(sum_line);
                                sum_line = string.Empty;
                                line_counter++;
                            }
                            sw.WriteLine(line);
                            line_counter++;
                        }
                        else if (line == null)
                        {
                            sum_line += line;
                        }
                        else
                        {
                            sum_line += line;
                        }
                        if (sr.Peek() == -1)
                        {
                            if (sum_line.Length > 0)
                            {
                                sw.WriteLine(sum_line);
                                sum_line = string.Empty;
                                line_counter++;
                            }
                            if (line.Length > 3)
                            {
                                sw.WriteLine(line);
                                line_counter++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"The number of lines in the new file:{line_counter}");
        }
    }
}
