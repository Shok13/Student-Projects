using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bmpInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_bmp = Console.ReadLine();
            if(file_bmp == "check")
            {
                file_bmp = @"D:\Projects\Безымянный.bmp";
            }
            else if(file_bmp == "check1")
            {
                file_bmp = @"D:\Projects\Безымянный1.bmp";
            }
            else if (file_bmp == "check2")
            {
                file_bmp = @"D:\Projects\Безымянный2.bmp";
            }
            var file_stream = new FileStream(file_bmp, FileMode.Open);
            file_stream.Seek(2, SeekOrigin.Begin);
            var br = new BinaryReader(file_stream);
            int size = br.ReadInt32();
            file_stream.Seek(12, SeekOrigin.Current);
            int width_px = br.ReadInt32();
            int height_px = br.ReadInt32();
            file_stream.Seek(2, SeekOrigin.Current);
            short bpi = br.ReadInt16();
            int compr_type = br.ReadInt32();
            string comp_type_txt=string.Empty;
            switch (compr_type)
            {
                case 0:
                    comp_type_txt = "BI_RGB";
                    break;
                case 1:
                    comp_type_txt = "BI_RLE8";
                    break;
                case 2:
                    comp_type_txt = "BI_RLE4";
                    break;
            }
            file_stream.Seek(4, SeekOrigin.Current);
            int hor_res = br.ReadInt32();
            int vert_res = br.ReadInt32();
            Console.WriteLine($"Size:{size,18}\n" +
                $"Width:{width_px,17}\nHeight:{height_px,16}\n" +
                $"BPI:{bpi,19}\nCompression:{comp_type_txt, 11}\n" +
                $"Horizontal resolution:{hor_res}\n" +
                $"Vertical resolution:  {vert_res}");
        }
    }
}
