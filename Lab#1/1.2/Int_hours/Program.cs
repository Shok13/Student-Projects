using System;

namespace Int_hours
{
    class Program
    {
        static void Main(string[] args)
        {

            int sec = 111111111;

            int hours = sec / 3600;
            int min = sec/60 - hours*60;
            int res = sec % 60;

            Console.WriteLine("Hours:{0,3} \nMinutes:{1,3} \nSeconds:{2,3}", hours , min, res);
            Console.ReadKey();


        }
    }
}
