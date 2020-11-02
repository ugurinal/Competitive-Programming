using System;
using System.Collections.Generic;

namespace MissingNumber
{
    internal class Finder
    {
        // Solution one to find missing number
        // in the below code,
        // At first it sorts the array using bubble sort
        // Then it checks every number in the array starting from zero to n if there is missing number
        // if there is is it returns that number if not it returns -1
        public static int FindMissingNumber(List<int> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = 0; j < arr.Count - (i + 1); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        //change values
                    }
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != i)
                    return i;
            }

            return -1;
        }

        // this solution is faster because we do not need to sort the elements in the array
        // in this solution, this code calculates the expected sum with (n * (n + 1)) / 2 formula
        // then calculated the sum of the elements in the array then compare them
        // if they are not equal then there is missing number and that is the difference of sums ( expectedSum - sum )
        // if they are equal then there is no missing number and returns 0
        public static int FindMissingNumberTwo(List<int> arr)
        {
            int n = arr.Count;
            int expectedSum = (n * (n + 1)) / 2;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            if (expectedSum != sum)
            {
                // there is missing number
                return expectedSum - sum;
            }
            else
            {
                // there is no missing number
                return 0;
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> temp = new List<int>();

            temp.Add(10);
            temp.Add(8);
            temp.Add(9);
            temp.Add(6);
            temp.Add(7);
            temp.Add(4);
            temp.Add(5);
            //temp.Add(2);
            temp.Add(3);
            temp.Add(1);
            temp.Add(0);

            int result = Finder.FindMissingNumber(temp);

            foreach (int x in temp)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(result + "\n" + "\n");

            List<int> temp2 = new List<int>();

            temp2.Add(10);
            temp2.Add(8);
            temp2.Add(9);
            temp2.Add(6);
            temp2.Add(7);
            temp2.Add(4);
            temp2.Add(5);
            //temp2.Add(2);
            temp2.Add(3);
            temp2.Add(1);
            temp2.Add(0);

            int result2 = Finder.FindMissingNumberTwo(temp2);

            foreach (int x in temp2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(result2);
        }
    }
}