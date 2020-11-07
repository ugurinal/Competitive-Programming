using System;

namespace CountingValleys
{
    internal class Program
    {
        public static int CountingValleys(int steps, string path)
        {
            int uCounter = 0;
            int valleyCounter = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    uCounter++;
                    if (uCounter == 0)
                    {
                        valleyCounter++;
                    }
                }
                else
                {
                    uCounter--;
                }
            }

            return valleyCounter;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}