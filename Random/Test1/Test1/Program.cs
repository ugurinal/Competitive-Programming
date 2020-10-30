using System;

namespace Test1
{
    public class Base
    {
        public Base()
        {
            Console.WriteLine("Base constructer called!");
        }

        public Base(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Derived : Base
    {
        public Derived() : base("hello")
        {
            Console.WriteLine("Derived constructer called!");
        }
    }

    internal class Program
    {
        private static void Main()
        {
            Derived derived = new Derived();
        }
    }
}