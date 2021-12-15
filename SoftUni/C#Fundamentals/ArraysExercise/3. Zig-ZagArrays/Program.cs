using System;
using System.Linq;

namespace _3._Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstNum = input[0];
                int secondNum = input[1];

                if (i % 2 == 0)
                {
                    firstArr[i] = firstNum;
                    secondArr[i] = secondNum;
                }
                else
                {
                    firstArr[i] = secondNum;
                    secondArr[i] = firstNum;
                }
            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write(firstArr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
