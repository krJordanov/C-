using System;

namespace NumberSequence
{
    class NumberSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min =int.MaxValue;
            int max =int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (max < num)
                {
                    max = num;
                }
                if (min > num)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
           
        }
    }
}
