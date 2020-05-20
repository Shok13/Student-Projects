using System;
using System.Windows.Input;
using System.Windows.Markup;
using System.IO;
using Tab_Sort;

namespace Tab
{
    class Program
    {
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
      
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString() + "\\lab.dat";
            Product.Product_[] products = new Product.Product_[3];
            Log.Log_[] logs = new Log.Log_[50];
    
            products[0] = new Product.Product_("Папка", Product.ProductType.К, 4.75m, 400);
            products[1] = new Product.Product_("Бумага А4(пачка)", Product.ProductType.К, 45.90m, 100);
            products[2] = new Product.Product_("Калькулятор", Product.ProductType.О, 411m, 10);

            Product.Product_.ReadInfo(ref products, path);

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
                        Product.ShowTab(products);
                        Product.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Add_Note:
                        Product.AddNote(ref products, ref logs, ref cnt);
                        Product.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Delete_Note:
                        Product.DeleteNote(ref products, ref logs, ref cnt);
                        Product.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Update_Note:
                        Product.UpdateNote(ref products, ref logs, ref cnt);
                        Product.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Search_Notes:
                        Product.SearchNotes(products);
                        Product.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Show_Log:
                        Console.Clear();
                        Product.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        Log.ShowLog(logs, idle_time);
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Sort_:
                        Product.Sort(products, 0, products.Length - 1);
                        Console.WriteLine("Сортировка завершена.");
                        Product.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Exit:
                        products[0].WriteInfo(products.Length, path, products);
                        exit = true;
                        break;
                    default:
                        time = DateTime.Now;
                        Product.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                }
            }
        }
    }
}
