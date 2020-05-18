using System;
using System.Diagnostics;
using System.IO;

namespace Search_Algorithms
{
    class Program
    {
        static int[] ReadInfo(string path)
        {
            var numbers = String.Empty;
            using (var sr = new StreamReader(path))
            {
                numbers = sr.ReadLine();
            }
            var numbersArray = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var numbersToSearch = new int[numbersArray.Length];
            int cnt = 0;
            foreach (string number in numbersArray)
            {
                numbersToSearch[cnt++] = Convert.ToInt32(number);
            }
            return numbersToSearch;
        }
        static void ShowResult(int position, long comparisons, TimeSpan interval)
        {
            var posText = String.Empty;
            if (position != -1)
            {
                posText = $"{position}";
            }
            else
            {
                posText = "Не найдено";
            }
            Console.WriteLine($"Позиция элемента - {posText,12}\n"
                             + $"Время работы - {interval.ToString(),16}\n"
                             + $"Количество сравнений:{comparisons,10}\n\n");
        }
        static int SetElement()
        {
            Console.Write("Введите число для поиска:");
            int select = 0;
            var isNotSelected = true;
            while (isNotSelected)
            {
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                    isNotSelected = false;
                }
                catch
                {
                    Console.WriteLine("Попробуйте заново!");
                }
            }
            Console.WriteLine();
            return select;
        }
        static int BinarySearch(int elem, int[] array)
        {
            long comparisons = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int left = 0;
            int right = array.Length - 1;
            while (right >= left)
            {
                int mid = (left + right) / 2;
                if (array[mid] == elem & comparisons++ >= 0)
                {
                    stopWatch.Stop();
                    ShowResult(mid, comparisons, stopWatch.Elapsed);
                    return mid;
                }
                if (array[mid] > elem & comparisons++ >= 0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            stopWatch.Stop();
            ShowResult(-1, comparisons, stopWatch.Elapsed);
            return -1;
        }
        static int InterpolationSearch(int elem, int[] array)
        {
            long comparisons = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int left = 0;
            int right = array.Length - 1;

            while (array[right] != array[left] && elem >= array[left] && elem <= array[right])
            {
                int mid = left + (elem - array[left]) * ((right - left) / (array[right] - array[left]));
                if (array[mid] < elem & comparisons++ >= 0)
                {
                    left = mid + 1;
                }
                else if (elem < array[mid] & comparisons++ >= 0)
                {
                    right = mid - 1;
                }
                else
                {
                    stopWatch.Stop();
                    ShowResult(mid, comparisons, stopWatch.Elapsed);
                    return mid;
                }
            }

            if (elem == array[left] & comparisons++ >= 0)
            {
                stopWatch.Stop();
                ShowResult(left, comparisons, stopWatch.Elapsed);
                return left;
            }
            else
            {
                stopWatch.Stop();
                ShowResult(-1, comparisons, stopWatch.Elapsed);
                return -1;
            }
        }
        static int LinearSearch(int elem, int[] array)
        {
            long comparisons = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == elem & comparisons++ >= 0)
                {
                    stopWatch.Stop();
                    ShowResult(i, comparisons, stopWatch.Elapsed);
                    return i;
                }
            }
            stopWatch.Stop();
            ShowResult(-1, comparisons, stopWatch.Elapsed);
            return -1;
        }

        static void Main(string[] args)
        {
            var numbersToSearch = new int[1];
            var isFileRead = true;
            try
            {
                numbersToSearch = ReadInfo(Directory.GetCurrentDirectory().ToString() + "\\sorted.dat");
            }
            catch
            {
                isFileRead = false;
                Console.WriteLine("Указанный файл не найден!");
            }
            if (isFileRead)
            {
                var element = SetElement();

                Console.WriteLine("Бинарный поиск");
                BinarySearch(element, numbersToSearch);

                Console.WriteLine("Линейный поиск");
                LinearSearch(element, numbersToSearch);

                Console.WriteLine("Интерполяционный поиск");
                InterpolationSearch(element, numbersToSearch);
            }
        }
    }
}
