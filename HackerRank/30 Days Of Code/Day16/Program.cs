using System;

namespace Day16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                int num = int.Parse(S);
                Console.WriteLine(num);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);

                Console.WriteLine("Bad String");
            }
        }
    }
}