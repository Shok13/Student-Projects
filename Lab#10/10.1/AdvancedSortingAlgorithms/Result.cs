using System;
using System.IO;

namespace AdvancedSortingAlgorithms
{
    class Result
    {
        public static void Show(ref long permutations,ref long comparisons, TimeSpan interval)
        {
            Console.WriteLine($"Количество перестановок:{permutations,12}\n"
                             + $"Количество сравнений:{comparisons,15}\n"
                             + $"Время работы - {interval.Seconds,17}:{interval.Milliseconds:000}\n\n");
            permutations = 0;
            comparisons =0;
        }
        public static void WriteInfo(int[] array, string path)
        {
            using (var sw = new StreamWriter(path, append: true))
            {
                foreach (int x in array)
                {
                    sw.Write(x + " ");
                }
                sw.WriteLine();
            }
        }
        private static int[] ConvertArray(string[] array)
        {
            var outArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                outArray[i] = Convert.ToInt32(array[i]);
            }
            return outArray;
        }
        private static void CheckSortedArray(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            var numbers = new System.Collections.Generic.List<int>();
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    double x = Math.Pow(2, i) * Math.Pow(3, j);
                    if (x < length / 2)
                    {
                        numbers.Add((int)x);
                    }
                    else
                    {
                        break;
                    }
                }
                if ((int)Math.Pow(2, i) > length / 2)
                {
                    break;
                }
            }
            int[] H = numbers.ToArray();
            Array.Sort(H);
            Array.Reverse(H);
            bool isSorted = true;
            foreach (int step in H)
            {
                for (int i = left + step; i <= right; i++)
                {
                    int j = i;
                    int tmp = array[i];

                    while (j >= left + step && tmp < array[j - step])
                    {
                        isSorted = false;
                        break;
                    }
                    if (!isSorted)
                    {
                        Console.WriteLine("Массив не отсортирован");
                        break;
                    }
                    array[j] = tmp;
                }
                if (!isSorted)
                {
                    Console.WriteLine("Массив не отсортирован");
                    break;
                }
            }
            if (isSorted)
            {
                Console.WriteLine("Массив отсортирован");
            }
        }
        public static void Check(string path)
        {
            using (var sr = new StreamReader(path))
            {
                while (sr.Peek() != -1)
                {
                    CheckSortedArray(ConvertArray(sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
                }
            }
        }
    }
}
