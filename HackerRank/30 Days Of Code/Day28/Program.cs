using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace Day28
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            List<string> names = new List<string>();

            Regex regex = new Regex("@gmail.com$");

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                if (regex.IsMatch(emailID))
                {
                    names.Add(firstName);
                }
            }

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}