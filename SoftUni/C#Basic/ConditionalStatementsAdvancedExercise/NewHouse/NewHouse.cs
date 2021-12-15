using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main()
        {
            string fllower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            double add = 0;

            //цвете                 	Роза	Далия	Лале	Нарцис	Гладиола
            // Цена на брой в лева        5     3.80    2.80       3      2.50
            //     "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            switch (fllower)
            {
                case  "Roses":
                        price = 5;
                    if (quantity > 80)
                    {
                        discount = 0.10;
                    }
                    break;
                case "Dahlias":
                    price = 3.80;
                    if (quantity > 90)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Tulips":
                    price = 2.80;
                    if (quantity > 80)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Narcissus":
                    price = 3;
                    if (quantity < 120)
                    {
                        add = 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = 2.50;
                    if (quantity < 80)
                    {
                        add = 0.20;
                    }
                    break;

            }
            double totalPrice = quantity * price;
            totalPrice = totalPrice - (totalPrice * discount);
            totalPrice = totalPrice + (totalPrice * add);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {fllower} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
