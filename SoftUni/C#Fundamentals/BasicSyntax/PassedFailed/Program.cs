﻿using System;

namespace PassedFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade < 3.00)
            {
                Console.WriteLine("Failed!");
            }
            else
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
