using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            string command = Console.ReadLine();

            while (songs.Count > 0)
            {
                int indexSeparator = command.IndexOf(' ');
                switch (indexSeparator == -1 ? command : command.Substring(0, indexSeparator))
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string songsAdd = command.Substring(indexSeparator + 1);
                        if (!songs.Contains(songsAdd))
                        {
                            songs.Enqueue(songsAdd);
                        }
                        else
                        {
                            Console.WriteLine($"{songsAdd} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
