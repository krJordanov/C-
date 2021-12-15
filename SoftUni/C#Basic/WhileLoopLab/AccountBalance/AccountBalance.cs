using System;

namespace AccountBalance
{
    class AccountBalance
    {
        static void Main(string[] args)
        {
            double payment = 0;

            while (true)
            {

                string input = Console.ReadLine();

                if (input != "NoMoreMoney")
                {
                    if (double.Parse(input) <= 0)
                    {
                        Console.WriteLine("Invalid operation!");
                        Console.WriteLine($"Total: {payment:f2}");
                        break;
                    }
                    else
                    {
                        payment += double.Parse(input);
                        Console.WriteLine($"Increase: {double.Parse(input):f2}");
                    }

                }
                else
                {
                    Console.WriteLine($"Total: {payment:f2}");
                    break;
                }
            }
        }
    }
}
