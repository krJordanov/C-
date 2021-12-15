using System;

namespace CleverLily
{
    class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            int toysCounter = 0;
            double money = 0;
            int stolenMoney = 0;
            double moneyPresent = 10;

            for (int currentYear = 1; currentYear <= age; currentYear++)
            {
                if (currentYear % 2 != 0)
                {
                    toysCounter++;
                }
                else
                {
                    stolenMoney++;
                    money += moneyPresent;
                    moneyPresent += 10; 
                }
            }
            double moneyForToys = toysCounter * toysPrice;
            double result = (money + moneyForToys) - stolenMoney;

            if (result >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {result - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - result:f2}");
            }
        }
    }
}
