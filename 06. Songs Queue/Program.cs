﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            while (songs.Count>0)
            {
                string cmd = Console.ReadLine();
                string[] command = cmd.Split(" ");
                switch (command[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = cmd.Substring(4);
                        if (!songs.Contains(song))
                        {
                            songs.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine($"{string.Join(", ",songs)}");
                        break;
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
