using System;

namespace Salary
{
    class alary
    {
        static void Main()
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= tabs; i++)
            {
                string penaltySites = Console.ReadLine();
                if (penaltySites == "Facebook")
                {
                    salary -= 150;
                }
                else if (penaltySites == "Instagram")
                {
                    salary -= 100;
                }
                else if (penaltySites == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}
