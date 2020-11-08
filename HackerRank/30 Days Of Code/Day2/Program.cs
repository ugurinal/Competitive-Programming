using System;

namespace Day2
{
    internal class Program
    {
        private static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            int totalCost = Convert.ToInt32(Math.Round((meal_cost + (meal_cost * tip_percent / 100) + (meal_cost * tax_percent / 100))));
            Console.WriteLine(totalCost);
        }

        private static void Main(string[] args)
        {
            solve(10.25, 17, 5);
        }
    }
}