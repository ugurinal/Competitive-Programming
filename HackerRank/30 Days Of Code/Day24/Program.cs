using System;

namespace Day24
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
        public static Node removeDuplicates(Node head)
        {
            if (head == null)
                return null;

            Node temp = head;

            int num1;
            int num2;

            while (temp.next != null)
            {
                num1 = temp.data;
                num2 = temp.next.data;

                if (num1 == num2)
                    temp.next = temp.next.next;
                else
                    temp = temp.next;
            }

            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);

            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;
            }
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
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}