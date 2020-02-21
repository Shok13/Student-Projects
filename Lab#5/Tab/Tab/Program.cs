using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tab
{
    class Program
    {
        enum ProductType
        {
            О,
            К
        }
        enum Action
        {
            ADD,
            DELETE,
            UPDATE
        }
        struct Product
        {
            public string name;
            public ProductType type;
            public decimal price;
            public uint amount;
            public void DisplayInfo()
            {
                Console.WriteLine($"|{name,-23}|{type}\t\t|{price:0.00}\t\t\t|{amount,-14}|");
            }
        }
        struct Log
        {
            public DateTime time;
            public Action action;
            public string name;

            public void DisplayLog()
            {
                switch (action)
                {
                    case Action.ADD:
                        Console.WriteLine($"{time.ToLongTimeString()} - Добавлена запись \"{name}\"");
                        break;
                    case Action.DELETE:
                        Console.WriteLine($"{time.ToLongTimeString()} - Удалена   запись \"{name}\"");
                        break;
                    case Action.UPDATE:
                        Console.WriteLine($"{time.ToLongTimeString()} - Обновлена запись \"{name}\"");
                        break;
                }
            }
        }
        static void CalcIdleTime(DateTime dt1, DateTime dt2, TimeSpan old_idle_time, out TimeSpan idle_time)
        {
            TimeSpan time = dt2 - dt1;
            if (time > old_idle_time)
            {
                idle_time = time;
            }
            else
            {
                idle_time = old_idle_time;
            }
        }
        static void CalcIdleTime(DateTime dt1, /*DateTime dt2, */TimeSpan old_idle_time, out TimeSpan idle_time)
        {
            DateTime dt2 = DateTime.Now;
            TimeSpan time = dt2 - dt1;
            if (time > old_idle_time)
            {
                idle_time = time;
            }
            else
            {
                idle_time = old_idle_time;
            }
        }

        static int GetNumber(int left_limit, int right_limit)
        {
            int select = Int32.MinValue;
            while (!(select >= left_limit && select <= right_limit))
            {
                Console.Write($"Введите значение от {left_limit} до {right_limit}:");
                try
                {
                    select = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Попробуйте заново!");
                }
            }
            return select;
        }
        static decimal GetPrice(decimal left_limit, decimal right_limit)
        {
            decimal price = Decimal.MinValue;
            while (!(price >= left_limit && price <= right_limit))
            {
                Console.Write($"Введите значение от {left_limit} до {right_limit}:");
                try
                {
                    price = Convert.ToDecimal(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Попробуйте заново!");
                }
            }
            return price;
        }
        static void ShowMenu()
        {
            Console.WriteLine("1 – Просмотр таблицы\n" +
                              "2 – Добавить запись\n" +
                              "3 – Удалить запись\n" +
                              "4 – Обновить запись\n" +
                              "5 – Поиск записей\n" +
                              "6 – Просмотреть лог\n" +
                              "7 - Выход");
        }
        static void ShowTab(Product[] products)
        {
            string s = "--------------------------------------------------------------------------------";
            Console.WriteLine(s);
            Console.WriteLine("|Прайс лист\t\t\t\t\t\t\t\t       |");
            Console.WriteLine(s);
            Console.WriteLine("|Наименование товара \t|Тип товара \t|Цена за 1 шт (грн) \t|Количество    |");
            Console.WriteLine(s);
            for (int i = 0; i < products.Length; i++)
            {
                products[i].DisplayInfo();
                Console.WriteLine(s);
            }
            Console.WriteLine("|Перечисляемый тип: О - оргтехника, К – канцтовары\t\t\t       |");
            Console.WriteLine(s);
        }
        static void ShowLog(Log[] logs, TimeSpan idle_time)
        {
            for (int i = 0; i < logs.Length; i++)
            {
                if (logs[i].name != null)
                {
                    logs[i].DisplayLog();
                }
            }
            Console.WriteLine($"\n{idle_time.Hours:00}:{idle_time.Minutes:00}:{idle_time.Seconds:00} - Самый долгий период бездействия пользователя");
        }
        static void AddNote(ref Product[] products, ref Log[] logs, ref int cnt)
        {
            Array.Resize(ref products, products.Length + 1);
            int last_pos = products.Length - 1;

            Console.Write("Введите наименование товара:");
            products[last_pos].name = (Console.ReadLine());

            Console.WriteLine("Укажите его тип (Оргтехника - 0, Канцтовары - 1)");
            products[last_pos].type = (ProductType)(GetNumber(0, 1));

            Console.WriteLine("Укажите цену за 1шт (грн)");
            products[last_pos].price = GetPrice(0, Decimal.MaxValue);

            Console.WriteLine("Укажите количество");
            products[last_pos].amount = (uint)GetNumber(0, Int32.MaxValue);
            AddLog(ref logs, DateTime.Now, 0, products[last_pos].name, ref cnt);
        }
        static void DeleteNote(ref Product[] products, ref Log[] logs, ref int cnt)
        {
            Console.WriteLine("Укажите номер записи, которую хотите удалить");
            int number = GetNumber(0, products.Length - 1);
            AddLog(ref logs, DateTime.Now, 1, products[number].name, ref cnt);
            for (int i = number; i < products.Length - 1; i++)
            {
                products[i] = products[i + 1];
            }
            Array.Resize(ref products, products.Length - 1);
        }
        static void UpdateNote(ref Product[] products, ref Log[] logs, ref int cnt)
        {
            Console.WriteLine("Укажите номер записи, которую хотите обновить");
            int number = GetNumber(0, products.Length - 1);
            AddLog(ref logs, DateTime.Now, 2, products[number].name, ref cnt);
            Console.Write("Введите наименование товара:");
            products[number].name = (Console.ReadLine());

            Console.WriteLine("Укажите его тип (Оргтехника - 0, Канцтовары - 1)");
            products[number].type = (ProductType)(GetNumber(0, 1));

            Console.WriteLine("Укажите цену за 1шт (грн)");
            products[number].price = GetPrice(0, Decimal.MaxValue);

            Console.WriteLine("Укажите количество");
            products[number].amount = (uint)GetNumber(0, Int32.MaxValue);
        }
        static void SearchNotes(Product[] products)
        {
            Console.WriteLine("Введите число, больше которого будет отображаться количество товаров");
            int amount = Int32.MinValue;
            amount = GetNumber(0, Int32.MaxValue);
            string s = "--------------------------------------------------------------------------------";
            Console.WriteLine(s);
            Console.WriteLine("|Прайс лист\t\t\t\t\t\t\t\t       |");
            Console.WriteLine(s);
            Console.WriteLine("|Наименование товара \t|Тип товара \t|Цена за 1 шт (грн) \t|Количество    |");
            Console.WriteLine(s);
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].amount > amount)
                {
                    products[i].DisplayInfo();
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("|Перечисляемый тип: О - оргтехника, К – канцтовары\t\t\t       |");
            Console.WriteLine(s);
        }
        static void AddLog(ref Log[] logs, DateTime time, int action, string name, ref int cnt)
        {
            if (cnt > 49)
            {
                for (int i = 0; i < logs.Length - 1; i++)
                {
                    logs[i] = logs[i + 1];
                }
                cnt = 49;
            }
            logs[cnt].time = time;
            logs[cnt].action = (Action)action;
            logs[cnt].name = name;

            cnt++;
        }
        static void Main(string[] args)
        {
            Product[] products = new Product[3];
            Log[] logs = new Log[50];

            products[0].name = "Папка";
            products[0].type = (ProductType)1;
            products[0].price = 4.75m;
            products[0].amount = 400;

            products[1].name = "Бумага А4(пачка)";
            products[1].type = (ProductType)1;
            products[1].price = 45.90m;
            products[1].amount = 100;

            products[2].name = "Калькулятор";
            products[2].type = (ProductType)0;
            products[2].price = 411m;
            products[2].amount = 10;

            int select = 0;
            int cnt = 0;
            TimeSpan idle_time = TimeSpan.Zero;
            DateTime time = DateTime.Now;
            while (select != 7)
            {
                switch (select)
                {
                    case 1:
                        ShowTab(products);
                        CalcIdleTime(time, DateTime.Now, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(1, 7);
                        break;
                    case 2:
                        AddNote(ref products, ref logs, ref cnt);
                        CalcIdleTime(time, DateTime.Now, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(1, 7);
                        break;
                    case 3:
                        DeleteNote(ref products, ref logs, ref cnt);
                        CalcIdleTime(time, DateTime.Now, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(1, 7);
                        break;
                    case 4:
                        UpdateNote(ref products, ref logs, ref cnt);
                        CalcIdleTime(time, DateTime.Now, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(1, 7);
                        break;
                    case 5:
                        SearchNotes(products);
                        CalcIdleTime(time, DateTime.Now, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(1, 7);
                        break;
                    case 6:
                        Console.Clear();
                        ShowLog(logs, idle_time);
                        CalcIdleTime(time, DateTime.Now, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(1, 7);
                        break;
                    default:
                        CalcIdleTime(time, DateTime.Now, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(1, 7);
                        break;
                }
            }
        }
    }
}
