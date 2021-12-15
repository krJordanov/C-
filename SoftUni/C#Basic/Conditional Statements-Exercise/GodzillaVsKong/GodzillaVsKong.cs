using System;

namespace GodzillaVsKong
{
    class GodzillaVsKong
    {
        static void Main()
        {
            // Input date

            double budget = double.Parse(Console.ReadLine());                  // бюджет
            int staff = int.Parse(Console.ReadLine());                         // персонал
            double singleClothingPrice = double.Parse(Console.ReadLine());     // цена за облекло на един статист

            double decorePrice = budget * 0.1;
            double allPriceForClothing = staff * singleClothingPrice;
            double totalCost = 0.0;

            if (staff > 150) 
            {
                allPriceForClothing *= 0.9;
            }
            totalCost = decorePrice + allPriceForClothing;

            if (totalCost > budget) 
            {
                double moneyNeeded = totalCost - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }

            else 
            {
                double extraMoney = budget - totalCost;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {extraMoney:f2} leva left.");
            }

        }
    }
}
