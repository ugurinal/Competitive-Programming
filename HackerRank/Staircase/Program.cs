using System;

namespace Staircase
{
    internal class Program
    {
        private static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }

        private static void Main(string[] args)
        {
            staircase(6);
        }
    }
}