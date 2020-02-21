using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string new_dir = @"D:\Projects\Lab6_temp";
            if (!Directory.Exists(new_dir))
            {
                Directory.CreateDirectory(new_dir);
            }
            FileInfo fi = new FileInfo(@"D:\Projects\Lab#6\lab.dat");
            fi.CopyTo(new_dir + @"\lab.dat", overwrite: true);

            using (var fs_r = new FileStream(new_dir + @"\lab.dat", FileMode.Open))
            {
                using (var fs_w = new FileStream(new_dir + @"\lab_backup.dat", FileMode.OpenOrCreate))
                {
                    fs_r.CopyTo(fs_w);
                }
            }
            //string line;
            //using (StreamReader sr = new StreamReader(new_dir + @"\lab_backup.dat"))
            //{
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            Console.WriteLine($"Size of the file:{fi.Length, 28}");
            Console.WriteLine($"Time of the last changing:{fi.LastWriteTime}");
            Console.WriteLine($"Time of the last access:  {fi.LastAccessTime}");
        }
    }
}
