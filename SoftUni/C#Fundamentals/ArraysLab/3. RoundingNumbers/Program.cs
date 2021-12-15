using System;
using System.Linq;

namespace _3._RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //0.9 1.5 2.4 2.5 3.14

            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 0;
                }
                int roundNum = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {roundNum}");
            }

        }
    }
}
