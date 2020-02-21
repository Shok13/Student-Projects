using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1st_ind
{
    class Program
    {
        static void CopyLast10()
        {
            FileStream fs = new FileStream("sin.dat", FileMode.Open);
            using (BinaryReader br = new BinaryReader(fs))
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open("copy.dat", FileMode.OpenOrCreate)))
                {
                    fs.Seek(-80, SeekOrigin.End);
                    for (int i = 0; i < 10; i++)
                    {
                        bw.Write(br.ReadDouble());
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("sin.dat", FileMode.OpenOrCreate);
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                for (int i = 30; i <= 90; i++)
                {
                    bw.Write(Math.Sin(Math.PI * i / 180));
                }
            }
            fs.Close();
            using (BinaryReader br = new BinaryReader(File.OpenRead("sin.dat")))
            {
                for (int i = 0; i < 61; i++)
                {
                    Console.WriteLine(br.ReadDouble());
                }
            }
            CopyLast10();
            using (BinaryReader br = new BinaryReader(File.OpenRead("copy.dat")))
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(br.ReadDouble());
                }
            }

        }
    }
}
