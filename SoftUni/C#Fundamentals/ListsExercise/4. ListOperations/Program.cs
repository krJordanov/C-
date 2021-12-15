using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool end = false;
            while (!end)
            {
                string operation = Console.ReadLine();
                if (operation == "End")
                {
                    end = true;
                    continue;
                }

                string[] command = operation.Split();
                switch (command[0])
                {
                    case "Add":
                        listInt.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) < 0 || int.Parse(command[2]) >= listInt.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        listInt.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= listInt.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        listInt.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Shift":
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                int firstNum = listInt[0];
                                listInt.Add(firstNum);
                                listInt.RemoveAt(0);
                            }
                        }
                        else if (command[1] == "right")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                int lastNum = listInt[listInt.Count - 1];
                                listInt.Insert(0, lastNum);
                                listInt.RemoveAt(listInt.Count - 1);
                            }
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", listInt));
        }
    }
}
