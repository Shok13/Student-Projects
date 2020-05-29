using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var bills = new int[100];
            for (int i = 0; i < bills.Length; i++)
            {
                var faceValue = new Random(i).Next(0, 7);
                switch (faceValue)
                {
                    case 0:
                        faceValue = 1;
                        break;
                    case 1:
                        faceValue = 2;
                        break;
                    case 2:
                        faceValue = 5;
                        break;
                    case 3:
                        faceValue = 10;
                        break;
                    case 4:
                        faceValue = 20;
                        break;
                    case 5:
                        faceValue = 50;
                        break;
                    case 6:
                        faceValue = 100;
                        break;
                }
                bills[i] = faceValue;
            }

            bills = Counting.Sort(bills, 0, bills.Length - 1);

            for (int i = 0; i < bills.Length; i++)
            {
                if (i == bills.Length - 1)
                {
                    Console.WriteLine(bills[i]);
                }
                else if (bills[i] != bills[i + 1])
                {
                    Console.WriteLine(bills[i]);
                }
                else
                {
                    Console.Write(bills[i]+" ");
                }
            }
        }
    }
}
