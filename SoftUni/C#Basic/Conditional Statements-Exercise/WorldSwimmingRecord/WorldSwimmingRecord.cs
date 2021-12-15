using System;

namespace WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main()
        {
            double recordTimeSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timePerMetersSwims = double.Parse(Console.ReadLine());

            double totalTime;

            double distance = distanceMeters * timePerMetersSwims;
            double resistance = Math.Floor(distanceMeters / 15) * 12.5;
            totalTime = distance + resistance;

            if (recordTimeSeconds <= totalTime) 
            {
                double timeNeeded = totalTime - recordTimeSeconds;

                Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
            }

            else 
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}
