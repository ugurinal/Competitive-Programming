using System;

namespace Day15
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class Program
    {
        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                return new Node(data);
            }

            Node current = head;

            while (current.next != null)
            {
                current = current.next;
            }

            Node item = new Node(data);
            current.next = item;
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        private static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}