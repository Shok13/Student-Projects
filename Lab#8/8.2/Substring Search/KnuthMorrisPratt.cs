using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_Search
{
    static class KnuthMorrisPratt
    {
        static KnuthMorrisPratt()
        {
            Console.WriteLine("Поиск по алгоритму КМП");
        }
        private static int[] computePrefixFunction(string s)
        {
            int[] pi = new int[s.Length];
            int j = 0;
            pi[0] = 0;

            for (int i = 1; i < s.Length; i++)
            {
                while (j > 0 && s[j] != s[i])
                {
                    j = pi[j];
                }

                if (s[j] == s[i])
                {
                    j++;
                }

                pi[i] = j;
            }
            return pi;
        }
        public static int Search(string pattern, string text)
        {
            long comparisons = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int[] prefix = computePrefixFunction(pattern);

            int q = 0;

            for (int i = 1; i <= text.Length; i++)
            {
                while (comparisons++ >= 0 & q > 0 && pattern[q] != text[i - 1])
                {
                    q = prefix[q - 1];
                }
                comparisons++;
                if (pattern[q] == text[i - 1])
                {
                    q++;
                }
                comparisons++;
                if (q == pattern.Length)
                {
                    stopWatch.Stop();
                    Result.Show(i - pattern.Length, comparisons, stopWatch.Elapsed);
                    return i - pattern.Length;
                }
            }
            stopWatch.Stop();
            Result.Show(-1, comparisons, stopWatch.Elapsed);
            return -1;
        }
        public static int SlowSearch(string pattern, string text)
        {
            long comparisons = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] prefix = computePrefixFunction(pattern + "|" + text);

            for (int pos = pattern.Length + 1; pos < prefix.Length; pos++)
            {
                comparisons++;
                if (prefix[pos] == pattern.Length)
                {
                    stopWatch.Stop();
                    Result.Show(pos - 2 * pattern.Length, comparisons, stopWatch.Elapsed);
                    return pos - 2 * pattern.Length;
                }
            }
            stopWatch.Stop();
            Result.Show(-1, comparisons, stopWatch.Elapsed);
            return -1;
        }
    }
}
