using System;

namespace OldBooks
{
    class OldBooks
    {
        static void Main()
        {
            string favoriteBook = Console.ReadLine();
            string input = Console.ReadLine();
            int counter = 0;

            while (input != favoriteBook)
            {
                input = Console.ReadLine();
                counter++;
                
                if (input == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    return;
                }
            }
            Console.WriteLine($"You checked {counter} books and found it.");
        }
    }
}
