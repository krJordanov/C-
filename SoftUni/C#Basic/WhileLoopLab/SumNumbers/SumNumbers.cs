using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            

            while (sum < num)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
