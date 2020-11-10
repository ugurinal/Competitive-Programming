using System;

namespace AVeryBigSum
{
    internal class Program
    {
        private static long aVeryBigSum(long[] ar)
        {
            long totalSum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                totalSum += ar[i];
            }

            return totalSum;
        }

        private static void Main(string[] args)
        {
        }
    }
}