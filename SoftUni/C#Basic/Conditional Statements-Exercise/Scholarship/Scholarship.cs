using System;

namespace Scholarship
{
    class Scholarship
    {
        static void Main()
        {
            double income = double.Parse(Console.ReadLine());  //dohod
            double GPA = double.Parse(Console.ReadLine());     // sreden uspeh
            double minWage = double.Parse(Console.ReadLine());   // minimalna rabotna zaplata

            double socialScholarShip = Math.Floor(minWage * 0.35);
            double exellentResult = Math.Floor(GPA * 25);

            //2. доход на член от семейството по-малък от минималната работна заплата и успех над 4.5.
            // Размер на социалната стипендия - 35% от минималната работна заплата

            // 3. Изискване за стипендия за отличен успех - успех над 5.5, включително. 
            //Размер на стипендията за отличен успех - успехът на ученика, умножен по коефициент 25.
            
            if (income < minWage && GPA >= 5.50) 
            {
               if(socialScholarShip > exellentResult) 
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarShip} BGN");
                }
               else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {exellentResult} BGN");
                }
            }
            else if (income < minWage && GPA > 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarShip} BGN");
            }
            else if (GPA >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {exellentResult} BGN");
            }
            else
            {

                Console.WriteLine($"You cannot get a scholarship!");
            }
        }
    }
}
