using System;

namespace TimeConversion
{
    internal class Program
    {
        private static string timeConversion(string s)
        {
            int hour = int.Parse(s.Substring(0, 2));
            int minute = int.Parse(s.Substring(3, 2));
            int second = int.Parse(s.Substring(6, 2));

            string format = s.Substring(8, 2);

            if (format == "PM" && hour != 12)
                hour += 12;

            if (format == "AM" && hour == 12)
                hour = 0;

            return hour.ToString("D2") + ":" + minute.ToString("D2") + ":" + second.ToString("D2");
        }

        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);
            // Sample Input 0
            // 07:05:45PM
            // Sample Input 1
            // 12:01:00AM

            Console.WriteLine(result);
        }
    }
}