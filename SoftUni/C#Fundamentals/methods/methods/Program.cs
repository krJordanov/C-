using System;

namespace methods
{
    class Program
    {

        public static string PrintName(string text)
        {
            Console.WriteLine($"Hello, {text}!");
            return text;
        }


        static void Main()

        {
            string username = Console.ReadLine();
            PrintName(username);

        }


    }
}
