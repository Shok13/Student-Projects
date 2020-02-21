using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Right
{
    class Program
    {
        static void ShowArray(int[,] ArrayToShow)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write($"{ArrayToShow[i, j]:00} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] array = new int[7, 7];
            for (int i = 0; i < 7; i++)
            {
                for (int j1 = 0; j1 < 7; j1++)
                {
                    array[i, j1] = i * 10 + j1;
                }
            }
            ShowArray(array);
            Console.WriteLine();

            int tmp1 = 0, tmp2 = 0, tmp3 = 0;

            int j = 0;
            int cnt = 0;
            int exit = 6;

            for (int i = 0; i < 3; i++)
            {
                for (; j < exit; j++)
                {
                    tmp1 = array[i, j];
                    array[i, j] = array[6 - j, i];

                    if (i == j)
                    {
                        tmp2 = array[i, 6 - j];
                        array[i, 6 - j] = tmp1;
                    }
                    else
                    {
                        tmp2 = array[j, 6 - i];
                        array[j, 6 - i] = tmp1;
                    }

                    tmp3 = array[6 - i, 6 - j];
                    array[6 - i, 6 - j] = tmp2;

                    array[6 - j, i] = tmp3;
                }
                j = ++cnt;
                exit--;
            }

            /* i,j -> 6-j,  i
             * if(d)  i,j -> i, 6-j
             *        i,j -> j, 6-i
             * i,j -> 6-i,6-j
             * i,j -> 6-j,  i */

            ShowArray(array);

        }
    }
}
