using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int maxNum = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "Stop")
                {
                    maxNum = Math.Max(maxNum, int.Parse(input));
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
