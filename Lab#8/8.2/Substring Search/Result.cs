using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_Search
{
    static class Result
    {
        public static void Show(int position, long comparisons, TimeSpan interval)
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
                             + $"Время работы - {interval.Seconds,9}:{interval.Milliseconds}.{interval.Ticks:0000}\n"
                             + $"Количество сравнений:{comparisons,10}\n\n");
        }
    }
}
