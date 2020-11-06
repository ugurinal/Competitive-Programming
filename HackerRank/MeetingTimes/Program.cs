using System;
using System.Collections.Generic;

namespace MeetingTimes
{
    internal class Result
    {
        public static List<List<int>> Combine(List<List<int>> meetingTimes)
        {
            List<List<int>> newMeetingTimes = new List<List<int>>();

            for (int i = 0; i < meetingTimes.Count - 1; i++)
            {
                int a = meetingTimes[i][1];

                for (int j = i + 1; j < meetingTimes.Count; j++)
                {
                    int b = meetingTimes[j][0];

                    if (a == b)
                    {
                        List<int> temp = new List<int>();

                        temp.Add(meetingTimes[i][0]);
                        temp.Add(meetingTimes[j][1]);

                        newMeetingTimes.Add(temp);

                        meetingTimes.RemoveAt(j);
                        meetingTimes.RemoveAt(i);
                    }
                }
            }

            for (int i = 0; i < meetingTimes.Count; i++)
            {
                List<int> temp = new List<int>();

                temp.Add(meetingTimes[i][0]);
                temp.Add(meetingTimes[i][1]);

                newMeetingTimes.Add(temp);
            }

            return newMeetingTimes;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<List<int>> meetingTimes = new List<List<int>>();

            List<int> temp = new List<int>();
            List<int> temp1 = new List<int>();
            List<int> temp2 = new List<int>();
            List<int> temp3 = new List<int>();
            List<int> temp4 = new List<int>();

            temp.Add(1);
            temp.Add(2);

            meetingTimes.Add(temp);

            temp2.Add(9);
            temp2.Add(14);

            meetingTimes.Add(temp2);

            temp1.Add(2);
            temp1.Add(8);

            meetingTimes.Add(temp1);

            temp3.Add(15);
            temp3.Add(18);
            meetingTimes.Add(temp3);

            temp4.Add(8);
            temp4.Add(15);
            meetingTimes.Add(temp4);

            for (int i = 0; i < meetingTimes.Count; i++)
            {
                Console.WriteLine("i = {2} -    {0} {1}", meetingTimes[i][0], meetingTimes[i][1], i);
            }

            Console.WriteLine("\n\n\n");

            meetingTimes = Result.Combine(meetingTimes);

            for (int i = 0; i < meetingTimes.Count; i++)
            {
                Console.WriteLine("i = {2} -    {0} {1}", meetingTimes[i][0], meetingTimes[i][1], i);
            }
        }
    }
}