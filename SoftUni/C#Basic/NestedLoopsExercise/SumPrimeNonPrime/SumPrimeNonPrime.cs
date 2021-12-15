using System;

namespace SumPrimeNonPrime
{
    class SumPrimeNonPrime
    {
        static void Main()
        {
            string input = Console.ReadLine(); ;
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {

                int inputNumber = int.Parse(input);

                if (inputNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                int primeCounter = 0;

                for (int i = 1; i <= inputNumber; i++)
                {
                    if (inputNumber % i == 0)
                    {
                        primeCounter++;
                    }
                }

                if (primeCounter == 2)
                {
                    primeSum += inputNumber;
                }
                else
                {
                    nonPrimeSum += inputNumber;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
