using System;
using System.IO;

namespace Tab_Sort
{
    public class Product
    {
        public enum ProductType
        {
            О,
            К
        }
        public struct Product_
        {
            public string Name;
            public ProductType Type;
            public decimal Price;
            public uint Amount;

            public Product_(string name, ProductType type, decimal price, uint amount)
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
            public void WriteInfo(int length, string path, Product_[] products)
            {

                using (StreamWriter sw = new StreamWriter(path, append: false))
                {
                    for (int i = 0; i < length; i++)
                    {
                        sw.WriteLine($"|{products[i].Name}|{products[i].Type}|{products[i].Price:0.00}|{products[i].Amount}|");
                    }
                }
                Console.WriteLine("Данные сохранены...");
            }
            public static void ReadInfo(ref Product.Product_[] products, string path)
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

        public static void ShowTab(Product.Product_[] products)
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
        public static void CalcMaxIdleTime(DateTime dt1, TimeSpan old_idle_time, out TimeSpan idle_time)
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

        public static int SetNumber(int left_limit, uint right_limit)
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
        public static ProductType SetProductType()
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
        public static ProductType GetProductType(char type)
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
        public static decimal SetPrice(decimal left_limit, decimal right_limit)
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

        public static void AddNote(ref Product.Product_[] products, ref Log.Log_[] logs, ref int cnt)
        {
            Array.Resize(ref products, products.Length + 1);
            int last_pos = products.Length - 1;

            Console.Write("Введите наименование товара:");
            string Name = (Console.ReadLine());

            Console.WriteLine("Укажите его тип (Оргтехника - O, Канцтовары - K)");
            var type = SetProductType();

            Console.WriteLine("Укажите цену за 1шт (грн)");
            var price = SetPrice(0, Decimal.MaxValue);

            Console.WriteLine("Укажите количество");
            var amount = (uint)SetNumber(0, UInt32.MaxValue);

            products[last_pos] = new Product_(Name, type, price, amount);
            Log.AddLog(ref logs, DateTime.Now, Log.Action.ADD, Name, ref cnt);
        }
        public static void AddNote(ref Product.Product_[] products, string[] data)
        {
            bool match = false;
            for (int i = 0; i < products.Length; i++)
            {
                if (data[0] == products[i].Name)
                {
                    match = true;
                }
            }
            if (!match)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = new Product_(data[0], GetProductType(Convert.ToChar(data[1])),
                                          Convert.ToDecimal(data[2]), Convert.ToUInt32(data[3]));
            }
        }
        public static void DeleteNote(ref Product.Product_[] products, ref Log.Log_[] logs, ref int cnt)
        {
            Console.WriteLine("Укажите номер записи, которую хотите удалить");
            int number = SetNumber(0, (uint)products.Length - 1);
            Log.AddLog(ref logs, DateTime.Now, Log.Action.DELETE, products[number].Name, ref cnt);
            for (int i = number; i < products.Length - 1; i++)
            {
                products[i] = products[i + 1];
            }
            Array.Resize(ref products, products.Length - 1);
        }
        public static void UpdateNote(ref Product.Product_[] products, ref Log.Log_[] logs, ref int cnt)
        {
            Console.WriteLine("Укажите номер записи, которую хотите обновить");
            int number = SetNumber(0, (uint)products.Length - 1);
            Log.AddLog(ref logs, DateTime.Now, Log.Action.UPDATE, products[number].Name, ref cnt);
            Console.Write("Введите наименование товара:");
            string Name = (Console.ReadLine());

            Console.WriteLine("Укажите его тип (Оргтехника - O, Канцтовары - K)");
            var type = SetProductType();

            Console.WriteLine("Укажите цену за 1шт (грн)");
            var price = SetPrice(0, Decimal.MaxValue);

            Console.WriteLine("Укажите количество");
            var amount = (uint)SetNumber(0, UInt32.MaxValue);
            products[number] = new Product_(Name, type, price, amount);
        }
        public static void SearchNotes(Product.Product_[] products)
        {
            Console.WriteLine("Введите число, больше которого будет отображаться количество товаров");
            int amount = Int32.MinValue;
            amount = SetNumber(0, Int32.MaxValue);
            string s = "--------------------------------------------------------------------------------";
            Console.WriteLine(s);
            Console.WriteLine("|Прайс лист\t\t\t\t\t\t\t\t       |");
            Console.WriteLine(s);
            Console.WriteLine("|Наименование товара \t|Тип товара \t|Цена за 1 шт (грн) \t|Количество    |");
            Console.WriteLine(s);
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Amount > amount)
                {
                    products[i].DisplayInfo();
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("|Перечисляемый тип: О - оргтехника, К – канцтовары\t\t\t       |");
            Console.WriteLine(s);
        }
        public static void Sort(Product.Product_[] products, int left, int right)
        {
            for (int i = left; i < right; i++)
            {
                int min = i;
                for (int j = i + 1; j <= right; j++)
                {
                    if (products[j].Price < products[min].Price)
                    {
                        min = j;
                    }
                }

                Swap(ref products[i], ref products[min]);
            }
        }
        static void Swap(ref Product_ products_first, ref Product_ products_second)
        {
            var Name = products_first.Name;
            var type = products_first.Type;
            var price = products_first.Price;
            var amount = products_first.Amount;

            products_first = new Product_(products_second.Name, products_second.Type, products_second.Price, products_second.Amount);
            products_second = new Product_(Name, type, price, amount);
        }

    }
}
