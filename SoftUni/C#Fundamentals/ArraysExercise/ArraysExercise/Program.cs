﻿using System;
using System.Linq;

namespace  Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());

            int[] train = new int[vagons];
            int sum = 0;

            for (int i = 0; i < vagons; i++)
            {
               int people = int.Parse(Console.ReadLine());

                train[i] = people;
    
            }
            for (int i = 0; i < train.Length; i++)
            {
                sum += train[i];
                Console.Write(train[i] +" ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
