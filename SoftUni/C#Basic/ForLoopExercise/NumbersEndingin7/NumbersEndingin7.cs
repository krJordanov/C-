﻿using System;

namespace NumbersEndingin7
{
    class NumbersEndingin7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 7; i <= 997; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
