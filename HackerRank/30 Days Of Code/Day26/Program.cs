using System;

namespace Day26
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] returnedDate = new int[3];
            int[] dueDate = new int[3];

            returnedDate = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            dueDate = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int fine = CalculateFine(returnedDate, dueDate);
            Console.WriteLine(fine);
        }

        private static int CalculateFine(int[] returnedDate, int[] dueDate)
        {
            int fine = 0;

            if (returnedDate[2] < dueDate[2])
            {
                fine = 0;
            }
            else
            {
                if (returnedDate[2] > dueDate[2])
                {
                    fine = 10000;
                }
                else if (returnedDate[1] > dueDate[1])
                {
                    fine = (returnedDate[1] - dueDate[1]) * 500;
                }
                else if (returnedDate[0] > dueDate[0])
                {
                    fine = (returnedDate[0] - dueDate[0]) * 15;
                }
            }
            return fine;
        }
    }
}