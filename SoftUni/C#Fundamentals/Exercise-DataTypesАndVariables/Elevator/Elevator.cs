using System;

namespace Elevator
{
    class Elevator
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int courses = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling((double)people / courses));
        }
    }
}
