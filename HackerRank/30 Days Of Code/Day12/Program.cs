using System;

namespace Day12
{
    internal class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person()
        {
        }

        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    internal class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = scores;
        }

        public char Calculate()
        {
            int sum = 0;
            int average;

            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
            }

            average = sum / testScores.Length;

            if (average >= 90)
                return 'O';
            else if (average >= 80)
                return 'E';
            else if (average >= 70)
                return 'A';
            else if (average >= 55)
                return 'P';
            else if (average >= 40)
                return 'D';
            else
                return 'T';
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}