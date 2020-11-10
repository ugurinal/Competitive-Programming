using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    internal class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int firstDiagonal = 0;
            int secondDiagonal = 0;

            int size = arr.Count;

            for (int i = 0; i < size; i++)
            {
                firstDiagonal += arr[i][i];
                secondDiagonal += arr[i][size - i - 1];
            }

            return Math.Abs(firstDiagonal - secondDiagonal);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}