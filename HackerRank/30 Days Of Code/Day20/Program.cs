using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day20
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);

            int numberOfSwaps = 0;
            int swapCounter = 0;

            // bubble sort
            for (int i = 0; i < a.Length; i++)
            {
                numberOfSwaps = 0;

                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        Console.WriteLine("{0} -  {1}", a[j], a[j + 1]);
                        Swap(ref a[j], ref a[j + 1]);
                        swapCounter++;
                        numberOfSwaps++;
                    }
                }

                if (numberOfSwaps == 0)
                    break;
            }

            Console.WriteLine("Array is sorted in {0} swaps.\n" +
                "First Element: {1}\n" +
                "Second Element: {2}\n", swapCounter, a[0], a[a.Length - 1]);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}