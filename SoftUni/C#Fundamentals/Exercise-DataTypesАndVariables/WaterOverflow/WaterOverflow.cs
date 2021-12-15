using System;

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int inputLitters = int.Parse(Console.ReadLine());
                if (sum + inputLitters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                
                    sum += inputLitters;
                
            }
            Console.WriteLine(sum);
        }
    }
}
