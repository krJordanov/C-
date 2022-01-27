using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int stelageCapacity = int.Parse(Console.ReadLine());
            int currentCloathes = 0;
            int stelageCounter = 1;

            while (clothes.Count > 0)
            {
                if (currentCloathes + clothes.Peek() > stelageCapacity)
                {
                    currentCloathes = 0;
                    stelageCounter++;
                }
                currentCloathes += clothes.Pop();
            }

            Console.WriteLine(stelageCounter);
        }
    }
}
