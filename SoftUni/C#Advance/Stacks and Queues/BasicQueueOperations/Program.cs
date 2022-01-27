using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            for (int i = 0; i < integers[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Contains(integers[2]) ? "true" : $"{queue.Min()}");
            }
        }
    }
}
