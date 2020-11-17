using System;

namespace Day11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int temp = 0;
            int max = int.MinValue;

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr[i].Length - 1; j++)
                {
                    for (int k = j; k < j + 3; k++)
                    {
                        temp += arr[i][k];
                        temp += arr[i + 2][k];
                    }
                    temp += arr[i][j + 1];
                    if (temp > max)
                    {
                        max = temp;
                    }
                    temp = 0;
                }
            }

            Console.WriteLine(max);
        }
    }
}