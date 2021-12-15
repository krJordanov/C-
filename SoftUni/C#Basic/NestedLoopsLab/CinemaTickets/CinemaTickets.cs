using System;

namespace CinemaTickets
{
    class CinemaTickets
    {
        static void Main()
        {
            string filmName = Console.ReadLine();
            int totalTickets = 0;
            int totalStudents = 0;
            int totalStandards = 0;
            int totalKids = 0;

            while (filmName != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                int tickets = 0;
                int student = 0;
                int standard = 0;
                int kid = 0;

                string type = Console.ReadLine();

                while (type != "End")
                {
                    tickets++;

                    switch (type)
                    {
                        case "student":
                            student++;
                            break;

                        case "standard":
                            standard++;
                            break;

                        case "kid":
                            kid++;
                            break;
                    }
                    if (tickets >= availableSeats)
                    {
                        break;
                    }
                    if (type == "Finish")
                    {
                        break;
                    }
                    type = Console.ReadLine();
                }
                totalTickets += tickets;
                totalStudents += student;
                totalStandards += standard;
                totalKids += kid;

                Console.WriteLine($"{filmName} - {(tickets / (double)availableSeats * 100):f2}% full.");

                if (filmName == "Finish")
                {
                    break;
                }
                filmName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(totalStudents / (double)totalTickets * 100):f2}% student tickets.");
            Console.WriteLine($"{(totalStandards / (double)totalTickets * 100):f2}% standard tickets.");
            Console.WriteLine($"{(totalKids / (double)totalTickets * 100):f2}% kids tickets.");
        }
    }
}
