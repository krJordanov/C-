using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{TotalPrice(product, quantity):F2}");

        }

        public static double TotalPrice(string text, int num)
        {
            double price = 0;
            //•	coffee – 1.50
            //•	water – 1.00
            //•	coke – 1.40
            //•	snacks – 2.00

            switch (text)
            {
                case "coffee":
                    price = 1.50;
                    break;

                case "water":
                    price = 1;
                    break;

                case "coke":
                    price = 1.40;
                    break;

                case "snacks":
                    price = 2;
                    break;

            }
            return price * num;
        }
    }
}
