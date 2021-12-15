using System;

namespace Password
{
    class Password
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string pass = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != pass )
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
        
    }
}
