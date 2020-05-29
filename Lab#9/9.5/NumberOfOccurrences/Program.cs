using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOccurrences
{
    class Program
    {
        static string ReadInfo(string path)
        {
            var sb = new StringBuilder();
            using(var sr = new StreamReader(path))
            {
                while (sr.Peek() != -1)
                {
                    sb.Append(sr.ReadLine());
                }
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string path = null;
            try
            {
                path = Directory.GetCurrentDirectory() + @"\text.txt";
            }
            catch
            {
                Console.WriteLine("File not found!");
            }
            string text = null;

            if (path!=null)
            {
                text = ReadInfo(path);
            }

            var wordsAndCounter = new Dictionary<string, int>();
            if (text!=null)
            {
                int value = 0;
                var words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                words = words.OrderBy(s => s).ToArray();
                words = words.Reverse().ToArray();
                foreach(var word in words)
                {
                    if(wordsAndCounter.TryGetValue(word, out value))
                    {
                        wordsAndCounter[word]++;
                    }
                    else
                    {
                        wordsAndCounter.Add(word, 1);
                    }
                }
                wordsAndCounter = wordsAndCounter.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
                wordsAndCounter = wordsAndCounter.Reverse().ToDictionary(pair => pair.Key, pair => pair.Value);
                int cnt = 0;
                foreach (var word in wordsAndCounter)
                {
                    if (cnt < 10)
                    {
                        Console.WriteLine(word.Key + " - " + word.Value);
                    }
                    cnt++;
                }

            }
        }
    }
}
