using System;

namespace Cake
{
    class Cake
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int s = a * b;
            int pieceArea = 1;
            int numberOfPieces = s / pieceArea;
            bool cakeIsOver = true;

            while (numberOfPieces > 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{numberOfPieces} pieces are left.");
                    cakeIsOver = false;
                    break;
                }

                numberOfPieces -= int.Parse(input);

            }

            if (cakeIsOver)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(numberOfPieces)} pieces more.");
            }
        }
    }
}
