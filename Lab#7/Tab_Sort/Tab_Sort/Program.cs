using System;
using System.Windows.Input;
using System.Windows.Markup;
using System.IO;

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
            private string Name;
            public string name
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name = value;
                }
            }
            private ProductType Type;
            public ProductType type => Type;

            private decimal Price;
            public decimal price => Price;

            private uint Amount;
            public uint amount => Amount;

            public Product(string name, ProductType type, decimal price, uint amount)
            {
                Name = name;
                Type = type;
                Price = price;
                Amount = amount;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"|{Name,-23}|{Type}\t\t|{Price,-23:0.00}|{Amount,-14}|");
            }
            public void WriteInfo(int length, string path, Product[] products)
            {

                using (StreamWriter sw = new StreamWriter(path, append: false))
                {
                    for (int i = 0; i < length; i++)
                    {
                        sw.WriteLine($"|{products[i].name}|{products[i].type}|{products[i].price:0.00}|{products[i].amount}|");
                    }
                }
                Console.WriteLine("Данные сохранены...");
            }
            public static void ReadInfo(ref Product[] products, string path)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (sr.Peek() != -1)
                        {
                            string[] data = sr.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                            if (data.Length == 4)
                            {
                                AddNote(ref products, data);
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Файл не обнаружен...\n");
                }
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

        static void CalcIdleTime(DateTime dt1, TimeSpan old_idle_time, out TimeSpan idle_time)
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

        static int GetNumber(int left_limit, uint right_limit)
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
        static ProductType GetTypeProduct()
        {
        Start:
            string input = Console.ReadLine();
            char type = input[0];

            if (type == 'O' || type == 'o' ||
                type == 'О' || type == 'о')
            {
                return ProductType.О;
            }
            else if (type == 'K' || type == 'k' || type == 'К' || type == 'к')
            {
                return ProductType.К;
            }
            else
            {
                goto Start;
            }
        }
        static ProductType GetTypeProduct(char type)
        {
            if (type == 'O' || type == 'o' ||
                type == 'О' || type == 'о')
            {
                return ProductType.О;
            }
            else if (type == 'K' || type == 'k' ||
                     type == 'К' || type == 'к')
            {
                return ProductType.К;
            }
            else
            {
                return ProductType.К;
            }
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
        const int Show_Tab = 1;
        const int Add_Note = 2;
        const int Delete_Note = 3;
        const int Update_Note = 4;
        const int Search_Notes = 5;
        const int Sort_ = 6;
        const int Show_Log = 7;
        const int Exit = 8;
        static void ShowMenu()
        {
            Console.WriteLine($"{Show_Tab} – Просмотр таблицы\n"
                            + $"{Add_Note} – Добавить запись\n"
                            + $"{Delete_Note} – Удалить запись\n"
                            + $"{Update_Note} – Обновить запись\n"
                            + $"{Search_Notes} – Поиск записей\n"
                            + $"{Sort_} - Сортировать по убыванию цены\n"
                            + $"{Show_Log} – Просмотреть лог\n"
                            + $"{Exit} - Выход");
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
            string name = (Console.ReadLine());

            Console.WriteLine("Укажите его тип (Оргтехника - O, Канцтовары - K)");
            var type = GetTypeProduct();

            Console.WriteLine("Укажите цену за 1шт (грн)");
            var price = GetPrice(0, Decimal.MaxValue);

            Console.WriteLine("Укажите количество");
            var amount = (uint)GetNumber(0, UInt32.MaxValue);

            products[last_pos] = new Product(name, type, price, amount);
            AddLog(ref logs, DateTime.Now, Action.ADD, name, ref cnt);
        }
        static void AddNote(ref Product[] products, string[] data)
        {
            bool match = false;
            for (int i = 0; i < products.Length; i++)
            {
                if (data[0] == products[i].name)
                {
                    match = true;
                }
            }
            if (!match)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = new Product(data[0], GetTypeProduct(Convert.ToChar(data[1])),
                                          Convert.ToDecimal(data[2]), Convert.ToUInt32(data[3]));
            }
        }
        static void DeleteNote(ref Product[] products, ref Log[] logs, ref int cnt)
        {
            Console.WriteLine("Укажите номер записи, которую хотите удалить");
            int number = GetNumber(0, (uint)products.Length - 1);
            AddLog(ref logs, DateTime.Now, Action.DELETE, products[number].name, ref cnt);
            for (int i = number; i < products.Length - 1; i++)
            {
                products[i] = products[i + 1];
            }
            Array.Resize(ref products, products.Length - 1);
        }
        static void UpdateNote(ref Product[] products, ref Log[] logs, ref int cnt)
        {
            Console.WriteLine("Укажите номер записи, которую хотите обновить");
            int number = GetNumber(0, (uint)products.Length - 1);
            AddLog(ref logs, DateTime.Now, Action.UPDATE, products[number].name, ref cnt);
            Console.Write("Введите наименование товара:");
            string name = (Console.ReadLine());

            Console.WriteLine("Укажите его тип (Оргтехника - O, Канцтовары - K)");
            var type = GetTypeProduct();

            Console.WriteLine("Укажите цену за 1шт (грн)");
            var price = GetPrice(0, Decimal.MaxValue);

            Console.WriteLine("Укажите количество");
            var amount = (uint)GetNumber(0, UInt32.MaxValue);
            products[number] = new Product(name, type, price, amount);
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
        static void Sort(Product[] products, int left, int right)
        {
            for (int i = left; i < right; i++)
            {
                int min = i;
                for (int j = i + 1; j <= right; j++)
                {
                    if (products[j].price < products[min].price)
                    {
                        min = j;
                    }
                }

                Swap(ref products[i], ref products[min]); 
            }
        }
        static void Swap(ref Product products_first, ref Product products_second)
        {
            var name = products_first.name;
            var type = products_first.type;
            var price = products_first.price;
            var amount = products_first.amount;

            products_first = new Product(products_second.name, products_second.type, products_second.price, products_second.amount);
            products_second = new Product(name, type, price, amount);
        }
        static void AddLog(ref Log[] logs, DateTime time, Action action, string name, ref int cnt)
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
            logs[cnt].action = action;
            logs[cnt].name = name;

            cnt++;
        }
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString() + "\\lab.dat";
            Product[] products = new Product[3];
            Log[] logs = new Log[50];

            products[0] = new Product("Папка", ProductType.К, 4.75m, 400);
            products[1] = new Product("Бумага А4(пачка)", ProductType.К, 45.90m, 100);
            products[2] = new Product("Калькулятор", ProductType.О, 411m, 10);

            Product.ReadInfo(ref products, path);

            int cnt = 0;

            int select = 0;
            bool exit = false;
            TimeSpan idle_time = TimeSpan.Zero;
            DateTime time = DateTime.Now;
            while (!exit)
            {
                switch (select)
                {
                    case Show_Tab:
                        ShowTab(products);
                        CalcIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(Show_Tab, Exit);
                        break;
                    case Add_Note:
                        AddNote(ref products, ref logs, ref cnt);
                        CalcIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(Show_Tab, Exit);
                        break;
                    case Delete_Note:
                        DeleteNote(ref products, ref logs, ref cnt);
                        CalcIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(Show_Tab, Exit);
                        break;
                    case Update_Note:
                        UpdateNote(ref products, ref logs, ref cnt);
                        CalcIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(Show_Tab, Exit);
                        break;
                    case Search_Notes:
                        SearchNotes(products);
                        CalcIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(Show_Tab, Exit);
                        break;
                    case Show_Log:
                        Console.Clear();
                        ShowLog(logs, idle_time);
                        CalcIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(Show_Tab, Exit);
                        break;
                    case Sort_:
                        Sort(products, 0, products.Length - 1);
                        Console.WriteLine("Сортировка завершена.");
                        CalcIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(Show_Tab, Exit);
                        break;
                    case Exit:
                        products[0].WriteInfo(products.Length, path, products);
                        exit = true;
                        break;
                    default:
                        CalcIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = GetNumber(Show_Tab, Exit);
                        break;
                }
            }
        }
    }
}
