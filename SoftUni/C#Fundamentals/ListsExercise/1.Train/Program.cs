    using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            bool end = false;
            while (!end)
            {
                string add = Console.ReadLine();

                if (add == "end")
                {
                    end = true;
                    continue;
                }

                string[] command = add.Split();
                switch (command[0])
                {
                    case "Add":
                        train.Add(int.Parse(command[1]));
                        break;
                    default:
                        int indexOfElement = train.FindIndex(x => x + int.Parse(command[0]) <= maxCapacity);
                        if (indexOfElement == -1)
                        {
                            continue;
                        }
                        train[indexOfElement] += int.Parse(command[0]);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
