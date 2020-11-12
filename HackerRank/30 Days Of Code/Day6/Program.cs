using System;
using System.Linq;

namespace Day6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string odd = "", even = "";

                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                        even += s[j];
                    else
                        odd += s[j];
                }

                Console.WriteLine("{0} {1}", even, odd);
            }
        }
    }
}