using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Console.WriteLine(Add(a, b));
            }
            else if (command == "multiply")
            {
                Console.WriteLine(Multiply(a,b));
            }
            else if (command == "subtract")
            {
                Console.WriteLine(Subtract(a, b));
            }
            else if (command == "divide")
            {
                Console.WriteLine(Divide(a, b));
            }

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
