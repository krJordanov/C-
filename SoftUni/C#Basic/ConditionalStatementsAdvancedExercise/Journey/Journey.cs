using System;

namespace Journey
{
    class Journey
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string type = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if ( budget >= 100 && budget <= 1000)
            {
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                destination = "Europe";
            }

            type = (season == "summer" && destination != "Europe") ? "Camp" : "Hotel";

            switch (destination)
            {
                case "Bulgaria":
                    budget *= (season == "summer") ? 0.3 : 0.7;
                    break;

                case "Balkans":
                    budget *= (season == "summer") ? 0.4 : 0.8;
                    break;

                case "Europe":
                    budget *= 0.9;
                    break;

               
            }
            Console.WriteLine($"Somewhere in {destination}" );
            Console.WriteLine($"{type} - {budget:f2}");
        }
    }
}
