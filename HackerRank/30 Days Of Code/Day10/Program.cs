using System;

namespace Day10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int max = 0;
            int prev = 0;

            for (int i = 0; n > 0; i++)
            {
                int temp = n % 2;
                n /= 2;
                if (temp == 1)
                {
                    prev++;
                    if (prev > max)
                    {
                        max = prev;
                    }
                }
                else
                {
                    prev = 0;
                }
            }

            Console.WriteLine(max);
        }
    }
}