using System;

namespace SummerOutfit
{
    class SummerOutfit
    {
        static void Main()
        {
            int degreese = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (day == "Morning")
            {
                if (10 <= degreese && degreese <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (18 < degreese && degreese <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreese >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (day == "Afternoon")
            {
                if (10 <= degreese && degreese <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (18 < degreese && degreese <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degreese >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (day == "Evening")
            {
                if (10 <= degreese && degreese <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (18 < degreese && degreese <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreese >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degreese} degrees, get your {outfit} and {shoes}.");
        }
    }
}
