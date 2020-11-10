using System;

namespace PlusMinus
{
    internal class Program
    {
        private static void plusMinus(int[] arr)
        {
            int pos = 0;
            int neg = 0;
            int zero = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    pos++;
                }
                else if (arr[i] < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine((double)pos / arr.Length);
            Console.WriteLine((double)neg / arr.Length);
            Console.WriteLine((double)zero / arr.Length);
        }

        private static void Main(string[] args)
        {
        }
    }
}