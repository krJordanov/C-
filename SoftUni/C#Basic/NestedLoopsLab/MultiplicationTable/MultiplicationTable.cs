﻿using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int sum = i * j;
                    Console.WriteLine($"{i} * {j} = {sum}");
                }
            }
        }
    }
}
