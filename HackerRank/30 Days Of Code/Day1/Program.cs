using System;

namespace Day1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int x;
            double y;
            string z;

            if (int.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
            {
                z = Console.ReadLine();

                Console.WriteLine("{0}", i + x);
                Console.WriteLine("{0:F1}", d + y); // f1 is for 8.0 , one decimal
                Console.WriteLine("{0}", s + z);
            }
            else
            {
                Console.WriteLine("Enter valid inputs.");
            }

            // Declare second integer, double, and String variables.

            // Read and save an integer, double, and String to your variables.

            // Print the sum of both integer variables on a new line.

            // Print the sum of the double variables on a new line.

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
        }
    }
}