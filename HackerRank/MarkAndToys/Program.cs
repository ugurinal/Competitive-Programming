using System;
using System.IO;

namespace MarkAndToys
{
    internal class Program
    {
        private static int MaximumToys(int[] prices, int k)
        {
            int counter = 0;

            int size = prices.Length;

            for (int i = 0; i < size - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < size - i - 1; j++)
                {
                    if (prices[j] < prices[j + 1])
                    {
                        int temp = prices[j];
                        prices[j] = prices[j + 1];
                        prices[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (k >= prices[size - i - 1])
                {
                    k -= prices[size - i - 1];
                    counter++;
                }
                else
                {
                    break;
                }

                if (!swapped)   // array is sorted
                {
                    break;
                }
            }

            return counter;
        }

        private static void Main(string[] args)
        {
        }
    }
}