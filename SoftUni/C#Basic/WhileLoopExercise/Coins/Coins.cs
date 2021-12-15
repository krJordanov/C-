using System;

namespace Coins
{
    class Coins
    {
        static void Main()
        {
            double change = double.Parse(Console.ReadLine());
            double coins = 0;
            double convert = change * 100;
            int cent = (int)convert;

            while (cent > 0)
            {
                if (cent - 200 >= 0)
                {
                    coins++;
                    cent -= 200;
                }
                else if (cent - 100 >= 0)
                {
                    coins++;
                    cent -= 100;
                }
                else if (cent - 50 >= 0)
                {
                    coins++;
                    cent -= 50;
                }
                else if (cent - 20 >= 0)
                {
                    coins++;
                    cent -= 20;
                }
                else if (cent - 10 >= 0)
                {
                    coins++;
                    cent -= 10;
                }
                else if (cent - 5 >= 0)
                {
                    coins++;
                    cent -= 5;
                }
                else if (cent - 2 >= 0)
                {
                    coins++;
                    cent -= 2;
                }
                else if (cent - 1 >= 0)
                {
                    coins++;
                    cent -= 1;
                }
            }
            Console.WriteLine(coins);

        }
    }
}
