using System;

namespace Day13
{
    internal abstract class Book
    {
        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }

        public abstract void display();
    }

    internal class MyBook : Book
    {
        private int price;

        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: {0}\nAuthor: {1}\nPrice: {2}", this.title, this.author, this.price);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}