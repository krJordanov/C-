using System;

namespace _2._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Grades(input);
        }
        public static void Grades(double input)
        {
            //•	2.00 – 2.99 - "Fail"
            //•	3.00 – 3.49 - "Poor"
            //•	3.50 – 4.49 - "Good"
            //•	4.50 – 5.49 - "Very good"
            //•	5.50 – 6.00 - "Excellent"

            if (input >= 2 && input < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (input >= 3 && input < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (input >= 3.50 && input < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (input >= 4.50 && input < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (input >= 5.50 && input < 6)
            {
                Console.WriteLine("Excellent");
            }

        }
    }
}
