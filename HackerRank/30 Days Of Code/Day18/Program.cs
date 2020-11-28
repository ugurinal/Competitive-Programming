using System;
using System.Collections.Generic;

namespace Day18
{
    internal class Program
    {
        private List<char> stack = new List<char>();
        private List<char> queue = new List<char>();

        public void pushCharacter(char c)
        {
            stack.Add(c);
        }

        public char popCharacter()
        {
            char character = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return character;
        }

        public void enqueueCharacter(char c)
        {
            queue.Add(c);
        }

        public char dequeueCharacter()
        {
            char character = queue[0];
            queue.RemoveAt(0);

            return character;
        }

        private static void Main(string[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Program obj = new Program();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}