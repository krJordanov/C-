using System;

namespace Moving
{
    class Moving
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int apartamentVolume = a * b * h;
            int numberOfBoxes = 0;

            while (numberOfBoxes <= apartamentVolume)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{apartamentVolume - numberOfBoxes} Cubic meters left.");
                    return;
                }
                numberOfBoxes += int.Parse(input);
            }
            Console.WriteLine($"No more free space! You need {numberOfBoxes - apartamentVolume} Cubic meters more.");
        }
    }
}
