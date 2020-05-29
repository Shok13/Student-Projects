using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCounting
{
    class Program
    {
        public static string Select(CircularLinkedList<string> names, int countingLength, string person)
        {
            var name = names.Find(person);
            for (int i = 0; i < countingLength; i++)
            {
                name = name.next;
            }
            return name.data;
        }
        static void Main(string[] args)
        {
            var names = new CircularLinkedList<string>();
            var namesText = new string[] { "Алина", "Илья", "Жора", "Настя", "Света", "Оксана" };
            Console.Write("В считалочку играют ");
            foreach (var name_ in namesText)
            {
                Console.Write(name_ + " ");
                names.Append(name_);
            }
            Console.WriteLine();

            Console.Write("Введите текст считалочки:");
            string counting = Console.ReadLine();
            Console.Write("Введите имя члоевека, с которого начать счёт:");
            var isCorrectName = false;
            string name = String.Empty;
            while (!isCorrectName)
            {
                name = Console.ReadLine();
                foreach (var name_ in namesText)
                {
                    if (name_ == name)
                    {
                        isCorrectName = true;
                    }
                }
            }
            var countingLength = counting.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length - 1;
            Console.WriteLine($"Считалочка закончилась на {Select(names, countingLength, name)}");
        }
    }
}
