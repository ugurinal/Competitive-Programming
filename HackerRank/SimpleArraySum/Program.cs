using System;

namespace SimpleArraySum
{
    internal class Program
    {
        private static int simpleArraySum(int[] ar)
        {
            int totalSum = 0;

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