using System;
using System.Collections.Generic;

namespace Day8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                keyValuePairs.Add(values[0], int.Parse((values[1])));
            }

            string key;

            while ((key = Console.ReadLine()) != null)
            {
                int value;

                if (keyValuePairs.TryGetValue(key, out value))
                {
                    Console.WriteLine("{0}={1}", key, value);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}