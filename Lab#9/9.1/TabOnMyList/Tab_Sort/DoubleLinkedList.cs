using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tab_Sort
{
    public class ListNode<T>
    {
        public T data;
        public ListNode<T> next;
        public ListNode<T> previous;
    }
    public class DoubleLinkedList<T> : ListNode<T>
    {
        ListNode<T> head = null;
        ListNode<T> tail = null;

        public void Append(T elem)
        {
            ListNode<T> node = new ListNode<T>();
            node.data = elem;
            node.next = null;
            node.previous = null;

            if (head == null)
            {
                head = node;
            }
            else
            {
                node.previous = tail;
                tail.next = node;
            }
            tail = node;
        }

        public void Prepend(T elem)
        {
            ListNode<T> node = new ListNode<T>();
            node.data = elem;
            node.next = null;
            node.previous = null;

            if (head == null)
            {
                head = node;
            }
            else
            {
                head.previous = node;
                node.next = head;
            }
            head = node;
        }

        public void Remove(T elem)
        {
            ListNode<T> node = head;
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
            if (node == head)
            {
                head = node.next;
                head.previous = null;
            }
            else
            {
                prevnode.next = node.next;
                node.previous = prevnode;
            }
            if (node == tail)
            {
                tail = prevnode;
            }
        }

        public int Count()
        {
            int n = 0;
            for (ListNode<T> node = head;
                             node != null;
                             node = node.next, n++);
            return n;
        }
        
        public T GetT(int pos)
        {
            if (this.Count()<=pos)
            {
                Console.WriteLine("Position is not correct!");
                return head.data;
            }
            else
            {
                ListNode<T> node = head;
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
                ListNode<T> node = head;
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
