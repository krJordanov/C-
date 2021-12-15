using System;

namespace ExamPreparation
{
    class ExamPreparation
    {
        static void Main()
        {
            int failLimit = int.Parse(Console.ReadLine());

            int numberOfProblems = 0;
            int numberOfFails = 0;
            double gradeSum = 0;
            string nameOfProblem = "";


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Enough")
                {
                    Console.WriteLine($"Average score: {(gradeSum / numberOfProblems):f2}");
                    Console.WriteLine($"Number of problems: {numberOfProblems}");
                    Console.WriteLine($"Last problem: {nameOfProblem}");
                    break;
                }

                nameOfProblem = input;
                double grade = double.Parse(Console.ReadLine());
                numberOfProblems++;
                gradeSum += grade;

                if (grade <= 4)
                {
                    numberOfFails++;
                }

                if (numberOfFails >= failLimit)
                {
                    Console.WriteLine($"You need a break, {failLimit} poor grades.");
                    break;
                }

            }
        }
    }
}
