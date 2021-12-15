using System;
using System.Linq;

namespace _4._ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().Reverse().ToArray();

            Console.Write(string.Join(" ",arr));
        }
    }
}
