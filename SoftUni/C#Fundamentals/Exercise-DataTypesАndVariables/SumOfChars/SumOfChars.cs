using System;

namespace SumOfChars
{
    class SumOfChars
    {
        static void Main()
        {
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    string inputChar = Console.ReadLine();

            //    sum += inputChar[0];
            //}
            //Console.WriteLine($"The sum equals: {sum}");

            //Vtori nachin

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                sum += symbol;
            }
            Console.WriteLine($"the sum equals: {sum}");
        }
    }
}
