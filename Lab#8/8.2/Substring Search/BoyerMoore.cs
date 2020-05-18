using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_Search
{
    static class BoyerMoore
    {
        static BoyerMoore()
        {
            Console.WriteLine("Поиск по алгоритму БМ");
        }
        private static int[] BadCharactersTable(string pattern)
        {
            int[] badShift = new int[256];

            for (int i = 0; i < 256; i++)
            {
                badShift[i] = -1;
            }

            for (int i = 0; i < pattern.Length - 1; i++)
            {
                badShift[(int)pattern[i]] = i;
            }

            return badShift;
        }
        private static int[] Suffixes(string pattern)
        {
            int length = pattern.Length;
            int[] suffixes = new int[length];
            suffixes[length - 1] = length;

            int g = length - 1;
            int f = 0;

            for (int i = length - 2; i >= 0; --i)
            {
                if (i > g && suffixes[i + length - 1 - f] < i - g)
                {
                    suffixes[i] = suffixes[i + length - 1 - f];
                }
                else
                {
                    if (i < g)
                    {
                        g = i;
                    }

                    f = i;

                    while (g >= 0 && pattern[g] == pattern[g + length - 1 - f])
                    {
                        g--;
                    }
                    suffixes[i] = f - g;
                }
            }

            return suffixes;
        }

        private static int[] GoodSuffixTable(string pattern)
        {
            int length = pattern.Length;
            int[] suffixes = Suffixes(pattern);
            int[] goodSuffixes = new int[length];

            for (int i = 0; i < length; i++)
            {
                goodSuffixes[i] = length;
            }

            for (int i = length - 1; i >= 0; i--)
            {
                if (suffixes[i] == i + 1)
                {
                    for (int j = 0; j < length - i - 1; j++)
                    {
                        if (goodSuffixes[j] == length)
                        {
                            goodSuffixes[j] = length - i - 1;
                        }
                    }
                }
            }

            for (int i = 0; i < length - 2; i++)
            {
                goodSuffixes[length - 1 - suffixes[i]] = length - i - 1;
            }

            return goodSuffixes;
        }
        public static int Search(string pattern, string text)
        {
            long comparisons = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            if (pattern.Length > text.Length)
            {
                stopWatch.Stop();
                Result.Show(-1, comparisons, stopWatch.Elapsed);
                return -1;
            }

            int[] badShift = BadCharactersTable(pattern);
            int[] goodSuffix = GoodSuffixTable(pattern);

            int offset = 0;

            while (offset <= text.Length - pattern.Length)
            {
                int i;
                for (i = pattern.Length - 1; comparisons++ >= 0 & i >= 0 && pattern[i] == text[i + offset]; i--);
                comparisons++;
                if (i < 0)
                {
                    stopWatch.Stop();
                    Result.Show(offset, comparisons, stopWatch.Elapsed);
                    return offset;
                }

                offset += Math.Max(i - badShift[(int)text[offset + i]], goodSuffix[i]);
            }
            stopWatch.Stop();
            Result.Show(-1, comparisons, stopWatch.Elapsed);
            return -1;
        }
    }
}
