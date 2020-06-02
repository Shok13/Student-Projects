using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayX_Y
{
    class Program
    {
        static int SetValue()
        {
            int x = 0;
            while (x < 1 || x > 8)
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x < 1 || x > 8)
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                catch
                {
                    Console.WriteLine("Try again!");
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            var matrix = new int[,] {
                {0, 1, 1, 0, 0, 0, 0, 0 },
                {1, 0, 0, 0, 0, 1, 1, 0},
                {1, 0, 0, 1, 0, 1, 0, 1},
                {0, 0, 1, 0, 1, 0, 0, 0},
                {0, 0, 0, 1, 0, 1, 0, 0},
                {0, 1, 1, 0, 1, 0, 0, 0},
                {0, 1, 0, 0, 0, 0, 0, 1},
                {0, 0, 1, 0, 0, 0, 1, 0}};
            var graph = new Graph(matrix, 8);

            Console.Write("Enter vertex X:");
            int x = SetValue();
            Console.Write("Enter vertex Y:");
            int y = SetValue();
            int cnt = 0;
            Console.WriteLine("BFS:");
            foreach (var num in graph.BFS(x-1, y-1))
            {
                if(cnt == 0)
                {
                    Console.Write(num+1);
                }
                else
                {
                    Console.Write("->" + (num + 1));
                }
                cnt++;
            }
            Console.WriteLine();
            cnt = 0;
            Console.WriteLine("DFS:");
            foreach (var num in graph.DFS(x - 1, y - 1))
            {
                if (cnt == 0)
                {
                    Console.Write(num + 1);
                }
                else
                {
                    Console.Write("->" + (num + 1));
                }
                cnt++;
            }
            Console.WriteLine();
        }
    }
}
