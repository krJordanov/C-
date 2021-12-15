using System;

namespace PokeMon
{
    class PokeMon
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int count = 0;
            int targets = 0;
            int halfOfN = N / 2;

            while (N > M)
            {
                targets++;
                N -= M;
                if (halfOfN == N && Y >0)
                {
                    N /= Y;
                }
                
            }
            Console.WriteLine(N);
            Console.WriteLine(targets);
        }
    }
}
