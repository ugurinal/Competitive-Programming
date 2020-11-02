using System;
using System.Collections.Generic;

namespace Triangles
{
    internal class Result
    {
        // Finds possible triangles
        public static int FindTriangles(List<int> nums)
        {
            int size = nums.Count;
            int counter = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < size; i++)
            {
                a = nums[i];
                for (int j = i + 1; j < size; j++)
                {
                    b = nums[j];

                    for (int k = j + 1; k < size; k++)
                    {
                        c = nums[k];

                        if (a == 0 || b == 0 || c == 0)
                            continue;

                        if (a + b > c && a + c > b && b + c > a)
                        {
                            Console.WriteLine("A = {0}, B = {1}, C = {2}", a, b, c);
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> temp = new List<int>();

            temp.Add(2);
            temp.Add(2);
            temp.Add(2);
            temp.Add(3);
            temp.Add(3);
            temp.Add(5);
            temp.Add(4);
            temp.Add(7);
            temp.Add(4);
            temp.Add(6);

            Console.WriteLine(Result.FindTriangles(temp));
        }
    }
}