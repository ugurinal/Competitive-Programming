using System;

namespace Day29
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int max = int.MinValue;

                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                for (int i = 1; i < n; i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        int temp = i & j;
                        if (temp > max && temp < k)
                        {
                            max = temp;
                        }
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}