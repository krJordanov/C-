using System;

namespace Travelling
{
    class Travelling
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string destination = input;

            while (input != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double saveAmount = 0;

                while (saveAmount < budget)
                {
                    double saves = double.Parse(Console.ReadLine());
                    saveAmount += saves;
                }
                Console.WriteLine($"Going to {input}!");
                input = Console.ReadLine();
                destination = input;

                if (input == "End")
                {
                    break;
                }
            }
            
        }
    }
}
