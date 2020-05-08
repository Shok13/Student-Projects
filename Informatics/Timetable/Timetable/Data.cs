using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    struct Event
    {
        public string Name;
        public string EventType;
        public DateTime Date;
        public DateTime Time;

        public Event(string name, string type, string date, string time)
        {
            Name = name;
            EventType = type;
            Date = DateTime.Parse(date);
            Time = DateTime.Parse(time);
        }
        
    }
    static class Data
    {
        public static List<Event> Events;
        static Data()
        {
            Events = new List<Event>();
        }

        public enum TypeData
        {
            Name,
            EventType,
            Date,
            Time
        }
        public static string GetData(int i,  TypeData typeData)
        {
            switch (typeData)
            {
                case TypeData.Name:
                    return Events[i].Name;
                case TypeData.EventType:
                    return Events[i].EventType;
                case TypeData.Date:
                    return Events[i].Date.ToShortDateString();
                case TypeData.Time:
                    return Events[i].Time.ToShortTimeString();
                default:
                    return "Exception";
            }
        }
        public static string WriteRow(int index)
        {
            return $"{Events[index].Name}{(char)1}{Events[index].EventType}{(char)1}{Events[index].Date}{(char)1}{Events[index].Time}";
        }
        public static void Record(Event @event)
        {
           Events.Add(@event);
        }
        public static void Sort()
        {
            Events.Sort(new TimeComparer());
        }
        public static void FillList(ListView list)
        {
            for (int i = 0; i < Data.Count(); i++)
            {
                var _event = new ListViewItem(Data.GetData(i, TypeData.EventType));
                _event.SubItems.Add(Data.GetData(i, TypeData.Date));
                _event.SubItems.Add(Data.GetData(i, TypeData.Time));
                _event.SubItems.Add(Data.GetData(i, TypeData.Name));
                list.Items.Add(_event);
            }
        }
        public static void Clear()
        {
            Events.Clear();
        }
        public static int Count()
        {
            return Events.Count;
        }
        public static void Insert(int i, int position)
        {
            Events.Insert(position, Events[i]);
            Events.RemoveAt(i + 1);
        }
        public static void Refresh(ListView list)
        {
            if (Count() != 0)
            { 
                Clear(); 
            }
            for (int i = 0; i < list.Items.Count; i++)
            {
                Record(new Event(list.Items[i].SubItems[3].Text, list.Items[i].SubItems[0].Text, list.Items[i].SubItems[1].Text, list.Items[i].SubItems[2].Text));
            }
        }
        public static void WriteInfo(string path)
        {
            using(var sw = new StreamWriter(path))
            {
                for(int i = 0; i<Events.Count; i++)
                {
                    sw.WriteLine(WriteRow(i));
                }
            }
        }
        public static void ReadInfo(Stream fs)
        {
            using (var sr = new StreamReader(fs))
            {
                while (sr.Peek() > -1)
                {
                    string[] data = sr.ReadLine().Split(new char[] { (char)1 }, StringSplitOptions.RemoveEmptyEntries);
                    if(data.Length == 4)
                    {
                        Data.Record(new Event(data[0], data[1], data[2], data[3]));
                    }            
                }
            }
        }
        class TimeComparer : IComparer<Event>
        {
            public int Compare(Event event1, Event event2)
            {
                return event1.Time.ToString().CompareTo(event2.Time.ToString());
            }
        }
    }
}
