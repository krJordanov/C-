﻿using System;

namespace DayOfWeek

{
    class Program
    {
        static void Main(string[] args)
        {

            int day = int.Parse(Console.ReadLine());
            string[] days = 
                {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
            };
           
            if (day < 0 || day > 7 || day == 0)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[day -1]);
            }
        }
    }
}
