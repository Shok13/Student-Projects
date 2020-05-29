using System;
using System.Collections.Generic;

namespace _1st_ind
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new LinkedList<int>();
            for(int i = 1; i < 6; i++)
            {
                elements.AddLast(i);
            }
            for (int i = 5; i > 0; i--) 
            {
                elements.AddLast(i);
            }
            Console.Write("Elements:");
            foreach(var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            var limit = 0;
            if (elements.Count % 2 == 0)
            {
                limit = elements.Count / 2;
            }
            else
            {
                limit = elements.Count / 2 + 1;
            }
            var isNotCorrect = false;
            var head = elements.First;
            var tail = elements.Last;
            for(int i = 0; i < limit; i++)
            {
                if(head.Value != tail.Value)
                {
                    isNotCorrect = true;
                    break;
                }
                head = head.Next;
                tail = tail.Previous;
            }
            if (!isNotCorrect)
            {
                Console.WriteLine("List items in reverse order form same chain as in direct order");
            }
            else
            {
                Console.WriteLine("List items in reverse do not form that same chain as in direct order");
            }
        }
    }
}
