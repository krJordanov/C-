using System;

namespace ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main()
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English"); break;
                case "Spain":
                case "Mexico":
                case "Argentina":
                    Console.WriteLine("Spanish"); break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
