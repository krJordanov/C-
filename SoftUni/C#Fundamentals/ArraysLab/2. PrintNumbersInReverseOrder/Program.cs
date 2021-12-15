using System;

namespace _2._PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];

            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
              
            }
            Array.Reverse(num);
            for (int i = 0; i <= num.Length -1; i++)
            {
                Console.Write(num[i] + " ");
            }
        
        }
    }
}
