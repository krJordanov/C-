using System;

namespace Time__15_Minutes
{
    class Program
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // 1. minutes < 45   --->  min + 15

            // 2. minutes >= 45    ---> (minutes + 15) - 60 , hour + 1

            // 3. minutes >=45  
               // minutes + 15) - 60 , hour +1
               // if  hour == 24 --> hour = 0

            if( minutes < 45) 
            {
                minutes += 15;
            }

            else if (minutes >= 45) 
            {
                minutes = (minutes + 15) -60;
                hour += 1;
            }
            if (hour == 24) 
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
