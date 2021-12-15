using System;

namespace Cinema
{
    class Cinema
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double price = 0;

            if (type == "Premiere")
            {
                price = (rows * colums) * 12;
            }
            else if (type == "Normal")
            {
                price = (rows * colums) * 7.5;
            }
            else if (type == "Discount")
            {
                price = (rows * colums) * 5;
            }
            Console.WriteLine($"{price:f2} leva");
        }
    }
}
