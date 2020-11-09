using System;

namespace AppleAndOrange
{
    internal class Program
    {
        private static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCounter = 0;
            int orangeCounter = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                if (apples[i] + a >= s && apples[i] + a <= t)
                {
                    appleCounter++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                if (oranges[i] + b >= s && oranges[i] + b <= t)
                {
                    orangeCounter++;
                }
            }

            Console.WriteLine(appleCounter);
            Console.WriteLine(orangeCounter);
        }

        private static void Main(string[] args)
        {
        }
    }
}