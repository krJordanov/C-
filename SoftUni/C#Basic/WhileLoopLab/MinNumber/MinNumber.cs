using System;

namespace MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            int minNum = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "Stop")
                {
                    minNum = Math.Min(minNum, int.Parse(input));
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
