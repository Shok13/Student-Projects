using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x3
{
    class Program
    {
        static int[,] AdditionOfArrays (int [,]array1, int[,] array2, out double average_value)
        {
            int[,] array_result = new int[3, 3];
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array_result[i, j] = array1[i, j] + array2[i, j];

                    sum += array_result[i, j];
                }
            }
            average_value = sum / (double)(array1.Length + array2.Length);

            return array_result;
        }
        static int[,] SubtractingArrays(int[,] array1, int[,] array2)
        {
            int[,] array_result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array_result[i, j] = array1[i, j] - array2[i, j];
                }
            }
           
            return array_result;
        }
        static void FillArray(ref int[,] array)
        {
            Random rnd = new Random();
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
            
        }
        static void ShowArray(int[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j != 2)
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
            int[,] first_array = new int[3, 3];
            int[,] second_array = new int[3, 3];

            FillArray(ref first_array);
            ShowArray(first_array);

            FillArray(ref second_array);
            ShowArray(second_array);

            int[,] array_plus = AdditionOfArrays(first_array, second_array, out double average_value);
            int[,] array_minus = SubtractingArrays(first_array, second_array);

            Console.WriteLine("+");
            ShowArray(array_plus);
            Console.WriteLine("-");
            ShowArray(array_minus);
            Console.WriteLine($"Average value = {average_value}");
            
        }
    }
}
