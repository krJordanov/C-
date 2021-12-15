using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine();
            string monthComparison = month.ToLower().Trim();
            int stayNights = int.Parse(Console.ReadLine());
            double studioDiscount = 0, apartmentDiscount = 0, studioPrice = 0, apartmentPrice = 0, totalCostStudio, totalCostApartment;

            if (stayNights > 14) apartmentDiscount = 0.1;

            if (monthComparison == "may" || monthComparison == "october")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                if (stayNights > 7 && stayNights <= 14)
                {
                    studioDiscount = 0.05;
                }
                else if (stayNights > 14)
                {
                    studioDiscount = 0.3;
                }

            }
            else if (monthComparison == "june" || monthComparison == "september")
            {
                studioPrice = 75.2;
                apartmentPrice = 68.7;

                if (stayNights > 14)
                {
                    studioDiscount = 0.2;
                }
            }
            else if (monthComparison == "july" || monthComparison == "august")
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }

            if (studioDiscount > 0) studioPrice -= studioPrice * studioDiscount;
            if (apartmentDiscount > 0) apartmentPrice -= apartmentPrice * apartmentDiscount;

            totalCostApartment = stayNights * apartmentPrice;
            totalCostStudio = stayNights * studioPrice;

            Console.WriteLine($"Apartment: {totalCostApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalCostStudio:f2} lv.");
        }
    }
}
