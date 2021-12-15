using System;
using System.Linq;

namespace SumDigits
{
    class SumDigits
    {
        static void Main()
        {
            int sum = Console.ReadLine()
                .Select(x => int.Parse(x.ToString()))               // събиране на всеки един символ от подадения вход!
            .Sum();
            Console.WriteLine(sum);


            //    int inputNum = int.Parse(Console.ReadLine());
            //    int sum = 0;

            //    while (inputNum > 0)
            //    {
            //        sum += inputNum % 10;
            //        inputNum /= 10;
            //    }
            //    Console.WriteLine(sum);
            //}
        }
    }
