using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_ind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[9, 9];
            int t = 1;
            
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (j == 1 && (i == 0 || i == 8))
                    {
                        array[i, j] = t++;
                    }
                    else if (j == 2 && (i < 2 || i > 6))
                    {
                        array[i, j] = t++;
                    }
                    else if (j == 3 && (i < 3 || i > 5))
                    {
                        array[i, j] = t++;
                    }
                    else if (j == 4 && (i < 4 || i > 4))
                    {
                        array[i, j] = t++;
                    }
                    else if (j == 5 && (i < 3 || i > 5))
                    {
                        array[i, j] = t++;
                    }
                    else if (j == 6 && (i < 2 || i > 6))
                    {
                        array[i, j] = t++;
                    }
                    else if (j == 7 && (i == 0 || i == 8))
                    {
                        array[i, j] = t++;
                    }
                    //if (i < 5)
                    //{
                    //    if (j > i && j < 8 - i)
                    //    {
                    //        array[i, j] = t++;
                    //    }
                    //    else
                    //    {
                    //        array[i, j] = 0;
                    //    }
                    //}
                    //else if (i > 3)
                    //{
                    //    if (j < i && j > 8 - i)
                    //    {
                    //        array[i, j] = t++;
                    //    }
                    //    else
                    //    {
                    //        array[i, j] = 0;
                    //    }
                    //}
                    //else array[i, j] = 0;

                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j != 8)
                    {
                        Console.Write($"{array[i, j]}\t");
                    }
                    else
                    {
                        Console.WriteLine(array[i, j]);
                    }
                }
            }
        }
    }
}
