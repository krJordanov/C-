using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            

            for (int i = 0; i < n; i++)
            {
                int sum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += sum;
                    
                }
                else
                {
                    odd += sum;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + even);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + Math.Abs(even - odd));
            }
            
        }
    }
}
