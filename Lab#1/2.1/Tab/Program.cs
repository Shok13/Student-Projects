using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tab
{

    class Program
    {
        struct product
        {
            public string name;
            public char type;
            public decimal price;
            public uint amount;
            public void DisplayInfo()
            {
                Console.WriteLine($"{name,-24}|{type}\t\t|{price:0.00}\t\t\t|{amount}");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Заполните таблицу.");

            product first;

            Console.Write("Введите наименование первого товара:");
            first.name = (Console.ReadLine());

            Console.Write("Укажите его тип:");
            first.type = Convert.ToChar(Console.ReadLine());

            /* 
            char type1 = ' ';
            try
            {
                type1 = Convert.ToChar(Console.ReadLine()); 
            }
            catch
            {
                Console.WriteLine("Ошибка ввода, попробуйте снова");
            }
            first.type = type1; 
            */

            /* 
            try
            {
                first.type = Convert.ToChar(Console.ReadLine()); 
            }
            catch
            {
                Console.WriteLine("Ошибка ввода, попробуйте снова");
            }
            */

            Console.Write("Укажите цену за 1шт (грн):");
            first.price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Укажите количество:");
            first.amount = Convert.ToUInt32(Console.ReadLine());



            product second;

            Console.Write("Введите наименование второго товара:");
            second.name = (Console.ReadLine());

            Console.Write("Укажите его тип:");
            second.type = Convert.ToChar(Console.ReadLine());

            Console.Write("Укажите цену за 1шт (грн):");
            second.price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Укажите количество:");
            second.amount = Convert.ToUInt32(Console.ReadLine());

            product third;

            Console.Write("Введите наименование третьего товара:");
            third.name = (Console.ReadLine());

            Console.Write("Укажите его тип:");
            third.type = Convert.ToChar(Console.ReadLine());

            Console.Write("Укажите цену за 1шт (грн):");
            third.price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Укажите количество:");
            third.amount = Convert.ToUInt32(Console.ReadLine());
            string s = "--------------------------------------------------------------------------------";

            Console.Clear();

            Console.WriteLine(s);
            Console.WriteLine("Прайс лист");
            Console.WriteLine(s);
            Console.WriteLine("Наименование товара \t|Тип товара \t|Цена за 1 шт (грн) \t|Количество"); 
            Console.WriteLine(s);
            first.DisplayInfo();
            Console.WriteLine(s);
            second.DisplayInfo();
            Console.WriteLine(s);
            third.DisplayInfo();
            Console.WriteLine(s);
            Console.WriteLine("Перечисляемый тип: К – канцтовары, О - оргтехника");
            Console.WriteLine(s);

        }
    }
}
