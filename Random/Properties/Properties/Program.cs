using System;

namespace Properties
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program program = new Program();

            int a = program.Add(53, 3);
            Console.WriteLine(a);
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}