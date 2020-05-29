using System;

namespace _1st_ind
{
    public class ListNode<T>
    {
        public T data;
        public ListNode<T> next;
        public ListNode<T> previous;
        public T GetData()
        {
            return data;
        }
    }
    public class DoubleLinkedList<T> : ListNode<T>
    {
        public ListNode<T> Head { get; private set; } = null;
        public ListNode<T> Tail { get; private set; } = null;
        public void Append(T elem)
        {
            ListNode<T> node = new ListNode<T>();
            node.data = elem;
            node.next = null;
            node.previous = null;

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.previous = Tail;
                Tail.next = node;
            }
            Tail = node;
        }

        public void Prepend(T elem)
        {
            ListNode<T> node = new ListNode<T>();
            node.data = elem;
            node.next = null;
            node.previous = null;

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Head.previous = node;
                node.next = Head;
            }
            Head = node;
        }

        public void Remove(T elem)
        {
            ListNode<T> node = Head;
            ListNode<T> prevnode = null;
            while (node != null && !node.data.Equals(elem))
            {
                prevnode = node;
                node = node.next;
            }

            if (node == null)
            {
                return;
            }
            if (node == Head)
            {
                Head = node.next;
                Head.previous = null;
            }
            else
            {
                prevnode.next = node.next;
                node.previous = prevnode;
            }
            if (node == Tail)
            {
                Tail = prevnode;
            }
        }

        public int Count()
        {
            int n = 0;
            for (ListNode<T> node = Head;
                             node != null;
                             node = node.next, n++) ;
            return n;
        }
        public T GetT(int pos)
        {
            if (this.Count() <= pos)
            {
                Console.WriteLine("Position is not correct!");
                return Head.data;
            }
            else
            {
                ListNode<T> node = Head;
                int i = 0;
                while (node != null && i != pos)
                {
                    node = node.next;
                    i++;
                }
                return node.data;
            }
        }

        public void Refresh(int pos, T newT)
        {
            if (this.Count() <= pos)
            {
                Console.WriteLine("Position is not correct!");
            }
            else
            {
                ListNode<T> node = Head;
                int i = 0;
                while (node != null && i != pos)
                {
                    node = node.next;
                    i++;
                }
                node.data = newT;
            }
        }

    }
}
