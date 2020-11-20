using System;
using System.Linq;

namespace Day14
{
    internal class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference()
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                    max = elements[i];
                if (elements[i] < min)
                    min = elements[i];
            }
            maximumDifference = Math.Abs(max - min);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}