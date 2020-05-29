using System;

namespace Tab_Sort
{
    public class Log
    {
        public enum Action
        {
            ADD,
            DELETE,
            UPDATE
        }
        public struct Log_
        {
            public DateTime time;
            public Action action;
            public string name;
            public Log_(DateTime t, Action a, string name)
            {
                time = t;
                action = a;
                this.name = name;
            }

            public void WriteLine()
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
        public static void ShowLog(DoubleLinkedList<Log_> logs, TimeSpan idle_time)
        {
            for (int i = 0; i < logs.Count(); i++)
            {
                var log = logs.GetT(i);
                if (log.name != null)
                {
                    log.WriteLine();
                }
            }
            Console.WriteLine($"\n{idle_time.Hours:00}:{idle_time.Minutes:00}:{idle_time.Seconds:00} - Самый долгий период бездействия пользователя");
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
    }
}
