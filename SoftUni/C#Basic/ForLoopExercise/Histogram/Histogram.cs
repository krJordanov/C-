using System;

namespace Histogram
{
    class Histogram
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            double p1Sum = 0;
            double p2Sum = 0;
            double p3Sum = 0;
            double p4Sum = 0;
            double p5Sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    p1++;
                  
                }
                else if (200 <= currentNum && currentNum <= 399)
                {
                    p2++;
                   
                }
                else if (400 <= currentNum && currentNum <= 599)
                {
                    p3++;
                   
                }
                else if (600 <= currentNum && currentNum <= 799)
                {
                    p4++;
                   
                }
                else if (currentNum >= 800)
                {
                    p5++;
                }
            }
            p1Sum += (p1 / n) * 100;
            p2Sum += (p2 / n) * 100;
            p3Sum += p3 / n * 100;
            p4Sum += p4 / n * 100;
            p5Sum += p5 / n * 100;

            Console.WriteLine($"{p1Sum:F2}%");
            Console.WriteLine($"{p2Sum:F2}%");
            Console.WriteLine($"{p3Sum:F2}%");
            Console.WriteLine($"{p4Sum:F2}%");
            Console.WriteLine($"{p5Sum:F2}%");
        }
    }
}
