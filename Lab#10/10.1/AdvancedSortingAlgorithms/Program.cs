using System;
using System.Collections.Generic;
using System.IO;
namespace AdvancedSortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString()).ToString() + "\\sorted.dat";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            var arrayLength = 100000;
            var randomArray = new int[arrayLength];
            var arrayToSort = new int[arrayLength];
            var rnd = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(1000);
            }
            long permutations = 0;
            long comparisons = 0;

            Array.Copy(randomArray, arrayToSort, randomArray.Length);
            Console.WriteLine("Сортировка слиянием массива, заполненного случайными числами");
            var start = DateTime.Now;
            var numbers = Merge.Sort(arrayToSort, 0, arrayToSort.Length-1,  ref permutations, ref comparisons);
            Result.Show(ref permutations,ref comparisons, DateTime.Now - start);
            Result.WriteInfo(numbers, path);

            Console.WriteLine("Сортировка слиянием массива, заполненного числами в порядке возрастания");
            start = DateTime.Now;
            numbers = Merge.Sort(arrayToSort, 0, arrayToSort.Length - 1, ref permutations, ref comparisons);
            Result.Show(ref permutations, ref comparisons, DateTime.Now - start);
            Result.WriteInfo(numbers, path);

            Array.Reverse(arrayToSort);
            Console.WriteLine("Сортировка слиянием массива, заполненного числами в порядке убывания");
            start = DateTime.Now;
            numbers = Merge.Sort(arrayToSort, 0, arrayToSort.Length - 1, ref permutations, ref comparisons);
            Result.Show(ref permutations, ref comparisons, DateTime.Now - start);
            Result.WriteInfo(numbers, path);

            Array.Copy(randomArray, arrayToSort, randomArray.Length);
            Console.WriteLine("Пирамидальная сортировка массива, заполненного случайными числами");
            start = DateTime.Now;
            numbers = Pyramid.Sort(arrayToSort, 0, arrayToSort.Length - 1, ref permutations, ref comparisons);
            Result.Show(ref permutations, ref comparisons, DateTime.Now - start);
            Result.WriteInfo(numbers, path);

            Console.WriteLine("Пирамидальная сортировка массива, заполненного числами в порядке возрастания");
            start = DateTime.Now;
            numbers = Pyramid.Sort(arrayToSort, 0, arrayToSort.Length - 1, ref permutations, ref comparisons);
            Result.Show(ref permutations, ref comparisons, DateTime.Now - start);
            Result.WriteInfo(numbers, path);

            Array.Reverse(arrayToSort);
            Console.WriteLine("Пирамидальная сортировка массива, заполненного числами в порядке убывания");
            start = DateTime.Now;
            numbers = Pyramid.Sort(arrayToSort, 0, arrayToSort.Length - 1, ref permutations, ref comparisons);
            Result.Show(ref permutations, ref comparisons, DateTime.Now - start);
            Result.WriteInfo(numbers, path);

            Array.Copy(randomArray, arrayToSort, randomArray.Length);
            Console.WriteLine("Быстрая сортировка массива, заполненного случайными числами");
            start = DateTime.Now;
            numbers = Quick.Sort(arrayToSort, 0, arrayToSort.Length - 1, ref permutations, ref comparisons);
            Result.Show(ref permutations, ref comparisons, DateTime.Now - start);
            Result.WriteInfo(numbers, path);

            Console.WriteLine("Быстрая сортировка массива, заполненного числами в порядке возрастания");
            start = DateTime.Now;
            numbers = Quick.Sort(arrayToSort, 0, arrayToSort.Length - 1, ref permutations, ref comparisons);
            Result.Show(ref permutations, ref comparisons, DateTime.Now - start);
            Result.WriteInfo(numbers, path);

            Array.Reverse(arrayToSort);
            Console.WriteLine("Пирамидальная сортировка массива, заполненного числами в порядке убывания");
            start = DateTime.Now;
            numbers = Quick.Sort(arrayToSort, 0, arrayToSort.Length - 1, ref permutations, ref comparisons);
            Result.Show(ref permutations, ref comparisons, DateTime.Now - start);
            Result.WriteInfo(numbers, path);

            Result.Check(path);
        }
    }
}
