using System;

namespace Vacation
{
    class Vacation
    {
        static void Main()
        {
            double neededMonerForVacation = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            double daysCounter = 0;
            double spendingCounter = 0;

            while (ownedMoney < neededMonerForVacation && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                
                if (command == "save")
                {
                    ownedMoney += money;
                    spendingCounter = 0;
                }
                else if (command == "spend")
                {
                    if (ownedMoney <= money)
                    {
                        ownedMoney = 0;
                    }
                    else
                    {
                        ownedMoney -= money;
                    }
                    spendingCounter++;
                }
                daysCounter++;
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (ownedMoney >= neededMonerForVacation)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
