using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_Search
{
    static class BruteForce
    {
        static BruteForce()
        {
            Console.WriteLine("Линейный поиск");
        }
        public static int Search(string pattern, string text)
        {
            long comparisons = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            int n = text.Length;
            int m = pattern.Length;
            for (int i = 0; i < n; i++)
            {
                int j = 0;

                for (; j < m; j++)
                {
                    comparisons++;
                    if (pattern[j] != text[i + j])
                    {
                        break;
                    }
                }
                if (j == m)
                {
                    stopWatch.Stop();
                    Result.Show(i, comparisons, stopWatch.Elapsed);
                    return i;
                }
            }
            stopWatch.Stop();
            Result.Show(-1, comparisons, stopWatch.Elapsed);
            return -1;
        }
    }
}
