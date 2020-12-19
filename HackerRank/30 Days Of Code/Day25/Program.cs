using System;

namespace Day25
{
    internal class Program
    {
        private static void isPrime(int a)
        {
            bool flag = false;

            if (a <= 1)
                flag = true;

            a = (int)Math.Sqrt(a);

            for (int i = 2; i <= a; i++)
            {
                if (a % i == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("Not prime");
            else
                Console.WriteLine("Prime");
        }

        private static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                isPrime(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}