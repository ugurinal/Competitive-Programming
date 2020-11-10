using System;

namespace MiniMaxSum
{
    internal class Program
    {
        private static void miniMaxSum(int[] arr)
        {
            long totalSum = 0;
            long min = arr[0];
            long max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                totalSum += arr[i];
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }

            Console.WriteLine("{0} {1}", totalSum - max, totalSum - min);
        }

        private static void Main(string[] args)
        {
        }
    }
}