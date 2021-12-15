using System;

namespace DivideWithoutRemainder
{
    class DivideWithoutRemainder
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;  
            double p2 = 0;  
            double p3 = 0;
            double count = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                count++;
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }

            }
            double p1Procent = p1 / count * 100;
            double p2Procent = p2 / count * 100;
            double p3Procent = p3 / count * 100;

            Console.WriteLine($"{p1Procent:f2}%");
            Console.WriteLine($"{p2Procent:f2}%");
            Console.WriteLine($"{p3Procent:f2}%");
        }
    }
}
