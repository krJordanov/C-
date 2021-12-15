using System;

namespace FishingBoat
{
    class FishingBoat
    {
        static void Main()
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishersNumber = int.Parse(Console.ReadLine());

            double boatPrice = 0;

            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;

                    break;

                case "Summer":
                case "Autumn":
                    boatPrice = 4200;
                    break;

                case "Winter":
                    boatPrice = 2600;
                    break;
            }
            if (fishersNumber <= 6)
            {
                boatPrice -= boatPrice * 0.10;
            }
            else if (fishersNumber >= 7 && fishersNumber <= 11)
            {
                boatPrice -= boatPrice * 0.15;
            }
            else
            {
                boatPrice -= boatPrice * 0.25;
            }
            if (fishersNumber % 2 == 00 && season != "Autumn")
            {
                boatPrice = boatPrice - (boatPrice * 0.05);
            }
            if (groupBudget < boatPrice)
            {
                Console.WriteLine($"Not enough money! You need {boatPrice - groupBudget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {groupBudget - boatPrice:f2} leva left.");
            }
        }
    }
}
