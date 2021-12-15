using System;

namespace _8._MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(number, power));
        }

        private static double MathPower(double a, int b)
        {
            double powerNum = a;
            for (int i = 1; i < b; i++)
            {
                powerNum *= a;
            }
            return powerNum;
        }
    }
}
