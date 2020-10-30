using System;

namespace Test2
{
    public class Base
    {
        public string firstName;
        public string lastName;

        public Base(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Console.WriteLine("Base constructor called");
        }

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
            // Console.WriteLine("{0} {1}", firstName, lastName);
            Console.WriteLine("Print name was called in base class.");
        }
    }

    public class Derived : Base
    {
        public Derived(string first, string last) : base(first, last)
        {
            Console.WriteLine("Derived constructor called");
        }

        public new void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("Print name was called in derived class.");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Derived derived = new Derived("first", "last");

            derived.PrintFullName();
            ((Base)derived).PrintFullName();

            /* OUTPUT */
            // Base constructor called
            // Derived constructor called
            // first last
            // Print name was called in derived class.
            // first last
            // Print name was called in base class.
        }
    }
}