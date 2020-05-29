using System;

namespace GameCounting
{
    public class ListNode<T>
    {
        public T data;
        public ListNode<T> next;
    }
    public class CircularLinkedList<T> : ListNode<T>
    {
        ListNode<T> head = null;
        ListNode<T> tail = null;

        public ListNode<T> First()
        {
            return head;
        }
        public void Append(T elem)
        {
            ListNode<T> node = new ListNode<T>();
            node.data = elem;
            node.next = null;

            if (head == null)
            {
                head = node;
                head.next = node;
            }
            else
            {
                tail.next = node;
            }
            tail = node;
            tail.next = head;
        }

        public void Prepend(T elem)
        {
            ListNode<T> node = new ListNode<T>();
            node.data = elem;
            node.next = null;

            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
            }
            head = node;
            tail.next = head;
        }

        public void Remove(T elem)
        {
            ListNode<T> node = head;
            ListNode<T> prevnode = null;
            while (!node.data.Equals(elem))
            {
                prevnode = node;
                node = node.next;
            }
            if (node == head)
            {
                head = node.next;
            }
            else
            {
                prevnode.next = node.next;
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
                             node != tail;
                             node = node.next, n++) ;
            return n;
        }
        public ListNode<T> Find(T elem)
        {
            ListNode<T> node = head;
            while (!node.data.Equals(elem))
            {
                node = node.next;
            }
            return node;
        }
    }
}