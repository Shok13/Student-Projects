using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_matrices_5x5
{
    class Program
    {
        static void FillArray(ref int[,] array)
        {

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }

        }
        static int[,] MultiplyMatrices(int[,] array1, int[,] array2)
        {
            int[,] array_result = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int m = 0; m < 5; m++)
                    {
                        array_result[i, j] += array2[m, j] * array1[i, m];
                    }
                }
            }
            return array_result;
        }
        static void ShowArray(int[,] array)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != 4)
                    {
                        Console.Write($"{array[i, j]}\t");
                    }
                    else
                    {
                        Console.WriteLine($"{array[i, j]}\t");
                    }
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[,] first_matrix = new int[5, 5];
            int[,] second_matrix = new int[5, 5];

            FillArray(ref first_matrix);
            ShowArray(first_matrix);

            FillArray(ref second_matrix);
            ShowArray(second_matrix);

            int[,] result_matrix = MultiplyMatrices(first_matrix, second_matrix);

            ShowArray(result_matrix);
        }
    }
}
