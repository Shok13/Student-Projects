using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3rd_ind
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text == "check")
            {
                text = @"D:\Projects\3rd_ind C:\Program Files\WinRAR D:\Steam\Steam\dumps\reports C:\Users\Андрей\.dotnet";
            }
            Regex rx = new Regex(@"\p{Lu}{1}:(\\\.?\w*\d*)+\b");

            foreach(Match match in rx.Matches(text))
            {
                Console.WriteLine(match);
            }
        }
    }
}
