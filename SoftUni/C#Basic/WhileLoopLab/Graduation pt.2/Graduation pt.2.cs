using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main()
        {
            string studentName = Console.ReadLine();
            double annualAssessmentSum = 0;
            int grades = 1;
            int repeats = 0;

            while (grades <= 12)
            {
                double annualAssessment = double.Parse(Console.ReadLine());

                if (annualAssessment < 4.00)
                {
                    repeats++;
                    if (repeats > 1)
                    {
                        break;
                    }
                    continue;
                }
                annualAssessmentSum += annualAssessment;
                grades++;
            }
            double average = annualAssessmentSum / 12;

            if (grades < 12)
            {
                Console.WriteLine($"{studentName} has been excluded at {grades} grade");
            }

            else
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {average:f2}");
               
            }    
                
        }
    }
}
