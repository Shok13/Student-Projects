using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            public void WriteInfo(string path, DoubleLinkedList<Product_> products)
            {
                using (StreamWriter sw = new StreamWriter(path, append: false))
                {
                    for (int i = 0; i < products.Count(); i++)
                    {
                        var product = products.GetT(i);
                        sw.WriteLine($"|{product.Name}|{product.Type}|{product.Price:0.00}|{product.Amount}|");
                    }
                }
                Console.WriteLine("Данные сохранены...");
            }
            public static void ReadInfo(DoubleLinkedList<Product_> products, string path)
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
                                var product = new Product_(data[0], GetProductType(data[1][0]), Convert.ToDecimal(data[2]), Convert.ToUInt32(data[3]));
                                AddNote(products, product);
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

        public static void ShowTab(DoubleLinkedList<Product_> products)
        {
            string s = "--------------------------------------------------------------------------------";
            Console.WriteLine(s);
            Console.WriteLine("|Прайс лист\t\t\t\t\t\t\t\t       |");
            Console.WriteLine(s);
            Console.WriteLine("|Наименование товара \t|Тип товара \t|Цена за 1 шт (грн) \t|Количество    |");
            Console.WriteLine(s);
            for (int i = 0; i < products.Count(); i++)
            {
                var product = products.GetT(i);
                product.DisplayInfo();
            }
            Console.WriteLine(s);
            Console.WriteLine("|Перечисляемый тип: О - оргтехника, К – канцтовары\t\t\t       |");
            Console.WriteLine(s);
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
            else if (type == 'K' || type == 'k' || 
                     type == 'К' || type == 'к')
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

        public static void AddNote(DoubleLinkedList<Product_> products, DoubleLinkedList<Log.Log_> logs)
        {
            Console.Write("Введите наименование товара:");
            string Name = (Console.ReadLine());

            Console.WriteLine("Укажите его тип (Оргтехника - O, Канцтовары - K)");
            var type = SetProductType();

            Console.WriteLine("Укажите цену за 1шт (грн)");
            var price = SetPrice(0, Decimal.MaxValue);

            Console.WriteLine("Укажите количество");
            var amount = (uint)SetNumber(0, UInt32.MaxValue);

            products.Append(new Product_(Name, type, price, amount));
            logs.Append(new Log.Log_(DateTime.Now, Log.Action.ADD, Name));
        }
        public static void AddNote(DoubleLinkedList<Product_> products, Product_ product)
        {
            products.Append(product);
        }
        public static void DeleteNote(DoubleLinkedList<Product_> products, DoubleLinkedList<Log.Log_> logs)
        {
            Console.WriteLine("Укажите номер записи, которую хотите удалить");
            int number = SetNumber(0, (uint)products.Count() - 1);
            var deleteProduct = products.GetT(number);
            logs.Append(new Log.Log_(DateTime.Now, Log.Action.DELETE, deleteProduct.Name));
            products.Remove(deleteProduct);
        }
        public static void UpdateNote(DoubleLinkedList<Product_> products, DoubleLinkedList<Log.Log_> logs)
        {
            Console.WriteLine("Укажите номер записи, которую хотите обновить");
            int number = SetNumber(0, (uint)products.Count() - 1);
            var updateProduct = products.GetT(number);
            logs.Append(new Log.Log_(DateTime.Now, Log.Action.UPDATE, updateProduct.Name));

            Console.Write("Введите наименование товара:");
            string Name = (Console.ReadLine());

            Console.WriteLine("Укажите его тип (Оргтехника - O, Канцтовары - K)");
            var type = SetProductType();

            Console.WriteLine("Укажите цену за 1шт (грн)");
            var price = SetPrice(0, Decimal.MaxValue);

            Console.WriteLine("Укажите количество");
            var amount = (uint)SetNumber(0, UInt32.MaxValue);

            products.Refresh(number, new Product_(Name, type, price, amount));
        }
        public static void SearchNotes(DoubleLinkedList<Product_> products)
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
            for (int i = 0; i < products.Count(); i++)
            {
                var product = products.GetT(i);
                if (product.Amount > amount)
                {
                    product.DisplayInfo();
                }
            }
            Console.WriteLine(s);
            Console.WriteLine("|Перечисляемый тип: О - оргтехника, К – канцтовары\t\t\t       |");
            Console.WriteLine(s);
        }
        public static void Sort(DoubleLinkedList<Product_> products, int left, int right)
        {
            for (int i = left; i < right; i++)
            {
                int min = i;
                for (int j = i + 1; j <= right; j++)
                {
                    var product1 = products.GetT(j);
                    var product2 = products.GetT(min);
                    if (product1.Price > product2.Price)
                    {
                        min = j;
                    }
                }
                Swap(products, i, min);
            }
        }
        static void Swap(DoubleLinkedList<Product_> products, int first, int second)
        {
            var dataFirst = products.GetT(first);
            var dataSecond = products.GetT(second);

            products.Refresh(first, dataSecond);
            products.Refresh(second, dataFirst);
        }

    }
}
