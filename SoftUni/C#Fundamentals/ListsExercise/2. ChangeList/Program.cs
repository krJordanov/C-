using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool end = false;
            while (!end)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    end = true;
                    continue;
                }

                string[] action = command.Split();
                switch (action[0])
                {
                    case "Delete":
                        list.RemoveAll(x => x == int.Parse(action[1]));
                        break;
                    case "Insert":
                        list.Insert(int.Parse(action[2]), int.Parse(action[1]));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
