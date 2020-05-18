using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Substring_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст для поиска подстроки:");
            var text = Console.ReadLine();
            Console.WriteLine();
            if (text == "test")
            {
                text = "In England the first of April is a very special day. This is the day when people make April’s Fools. April’s Fool is a joke and sometimes a hoax to someone. In fact everyone, adults and children, take part in the celebration. Earlier they made a fool by giving meaningless errands, for example, a person had to find sweet vinegar.Now schoolboys and schoolgirls hang paper with funny words at their classmates’ backs.They also can change and move the clock hands.Sometimes they give funny cards and little presents. Adults make more elaborate jokes.They can be together to prepare a hoax to a friend.The main thing is that others will believe in it and then it will be funny. The most amazing thing is that the press also makes April’s Fools.Listening to the radio, watching television or reading the newspapers, you will inevitably see funny news on April fool’s Day.It always happens, because it is a tradition of the 1st of April. Fox example, in 1999 the BBC, the famous British channel, announced that the British anthem will be replaced by a modern European song.Thousands of listeners were confused and outraged. There is also a rule in England that all the jokes have to be stopped at 12 pm.But in Scotland there are its own rules, they celebrate this holiday during two days.The second day is called ‘Taily Day’. All the jokes and hoaxes are about the part of human body which is located below the waist from the back.Putting pins and little bags with air on the chair is very popular on that day.Everywhere people can see pictures and posters with the words ‘Give me a kick’ which is a motto of the Taily Day.";
            }

            Console.Write("Введите шаблон для поиска:");
            var pattern = Console.ReadLine();
            Console.WriteLine();

            if (text.Length - pattern.Length > 0)
            {
                BruteForce.Search(pattern, text);
                KnuthMorrisPratt.Search(pattern, text);
                Console.WriteLine("Медленный поиск по алгоритму КМП");
                KnuthMorrisPratt.SlowSearch(pattern, text);
                BoyerMoore.Search(pattern, text);
            }
            else
            {
                Console.WriteLine("Длина шаблона превышает длину текста");
            }
        }
    }
}
