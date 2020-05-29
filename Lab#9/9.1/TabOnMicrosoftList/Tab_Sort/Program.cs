using System;
using System.Collections.Generic;
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
            LinkedList<Product.Product_> products = new LinkedList<Product.Product_>();
            LinkedList<Log.Log_> logs = new LinkedList<Log.Log_>();
            Product.Product_.ReadInfo(products, path);

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
                        Log.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Add_Note:
                        Product.AddNote(products, logs);
                        Log.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Delete_Note:
                        Product.DeleteNote(products, logs);
                        Log.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Update_Note:
                        Product.UpdateNote(products, logs);
                        Log.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Search_Notes:
                        Product.SearchNotes(products);
                        Log.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Show_Log:
                        Console.Clear();
                        Log.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        Log.ShowLog(logs, idle_time);
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Sort_:
                        products = Product.Sort(products);
                        Console.WriteLine("Сортировка завершена.");
                        Log.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                    case Exit:
                        products.First.Value.WriteInfo(path, products);
                        exit = true;
                        break;
                    default:
                        time = DateTime.Now;
                        Log.CalcMaxIdleTime(time, idle_time, out idle_time);
                        time = DateTime.Now;
                        ShowMenu();
                        select = Product.SetNumber(Show_Tab, Exit);
                        break;
                }
            }
        }
    }
}
