﻿using System;
using System.Linq;

namespace _7._MaxSequenceОfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;
            int maxCounter = 0;
            int valueBiggiest = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length -1 && input[i] == input [i + 1])
                {
                    counter++;
                }
                else if (i < input.Length - 1 && input[i] != input[i + 1])
                {
                    counter++;
                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                        valueBiggiest = input[i];
                    }
                    counter = 0;
                }
                else if (input[i] == input[input.Length -1])
                {
                    counter++;
                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                        valueBiggiest = input[i];
                    }
                    counter = 0;
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(valueBiggiest + " ");
            }
        }
    }
}
