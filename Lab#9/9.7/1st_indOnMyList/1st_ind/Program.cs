using System;

namespace _1st_ind
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new DoubleLinkedList<int>();
            for(int i = 1; i < 6; i++)
            {
                elements.Append(i);
            }
            for (int i = 5; i > 0; i--) 
            {
                elements.Append(i);
            }

            Console.Write("Elements:");
            for (int i = 0; i<elements.Count(); i++)
            {
                Console.Write(elements.GetT(i)+ " ");
            }
            Console.WriteLine();
            var limit = 0;
            if (elements.Count() % 2 == 0)
            {
                limit = elements.Count() / 2;
            }
            else
            {
                limit = elements.Count() / 2 + 1;
            }
            var isNotCorrect = false;
            var head = elements.Head;
            var tail = elements.Tail;
            for(int i = 0; i < limit; i++)
            {
                if(head.GetData() != tail.GetData())
                {
                    isNotCorrect = true;
                    break;
                }
                head = head.next;
                tail = tail.previous;
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
