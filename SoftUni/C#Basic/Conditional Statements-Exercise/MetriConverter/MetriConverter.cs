﻿using System;

namespace MetriConverter
{
    class MetriConverter
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "mm")
            {
                number /= 1000;
            }

            else if (input == "cm")
            {
                number /= 100;
            }
           if (output == "mm")
            {
                number *= 1000;
            }
            else if (output == "cm")
            {
                number *= 100;
            }

            Console.WriteLine($"{number:f3}");
        }
    }
}
