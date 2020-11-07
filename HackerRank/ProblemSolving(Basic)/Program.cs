using System;

namespace ProblemSolving_Basic_
{
    internal class Result
    {
        public static string findSubstring(string s, int k)
        {
            char[] wovels = { 'a', 'e', 'i', 'o', 'u' };

            int index = 0;
            int temp = 0;
            int maximum = 0;
            for (int i = 0; i < s.Length - k; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    for (int l = 0; l < wovels.Length; l++)
                    {
                        if (s[i + j] == wovels[l])
                        {
                            temp++;
                        }
                    }
                    if (temp > maximum)
                    {
                        maximum = temp;
                        temp = 0;
                        index = i;
                    }
                }
            }
            if (maximum != 0)
            {
                return s.Substring(index + 1, k);
            }
            else
            {
                return "Not found!";
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine(Result.findSubstring("azerdii", 5));
        }
    }
}