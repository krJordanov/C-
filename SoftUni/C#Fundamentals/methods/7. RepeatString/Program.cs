using System;

namespace _7._RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, count));
        }

        private static string RepeatString(string text, int n)
        {
            string newString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                newString += text;
            }
            return newString;
        }
    }
}
