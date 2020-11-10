using System;
using System.Collections.Generic;

namespace CompareTheTriplets
{
    internal class Program
    {
        private static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int size = a.Count;

            int alicePoint = 0;
            int bobPoint = 0;

            for (int i = 0; i < size; i++)
            {
                if (a[i] > b[i])
                    alicePoint++;
                else if (b[i] > a[i])
                    bobPoint++;
            }

            List<int> result = new List<int>();
            result.Add(alicePoint);
            result.Add(bobPoint);

            return result;
        }

        private static void Main(string[] args)
        {
        }
    }
}