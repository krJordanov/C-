using System;

namespace Building
{
    class Building
    {
        static void Main()
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string index = "";
           

            for (int floorCounter = floors; floorCounter > 0; floorCounter--)
            {
                for (int roomCounter = 0; roomCounter < rooms; roomCounter++)
                {
                    if (floorCounter == floors)
                    {
                        index = "L";
                    }
                    else if (floorCounter % 2 == 0)
                    {
                        index = "O";
                    }
                    else
                    {
                        index = "A";
                    }
                    Console.Write($"{index}{floorCounter}{roomCounter} ");
                }
                Console.WriteLine();
            }
        }
    }
}
