using System;

namespace TrainTheTrainers
{
    class TrainTheTrainers
    {
        static void Main()
        {
            int jouryCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int gradeCount = 0;
            double sumOfAllGrades = 0;

            while (input != "Finish")
            {
                double sumOfGardes = 0;

                for (int i = 0; i < jouryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGardes += grade;
                    sumOfAllGrades += grade;
                    gradeCount++;

                }
                double averageScore = sumOfGardes / jouryCount;

                Console.WriteLine($"{input} - {averageScore:f2}.");

                input = Console.ReadLine();
            }

            double averageFinal = sumOfAllGrades / gradeCount;

            Console.WriteLine($"Student's final assessment is {averageFinal:f2}.");
        }
        
    }
}
