using System;

namespace Day9
{
    internal class Program
    {
        private static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return factorial(n - 1) * n;
        }

        private static void Main(string[] args)
        {
        }
    }
}