﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int N = queue.Dequeue();
            int S = queue.Dequeue();
            int X = queue.Dequeue();
            for (int i = 0; i < S; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            if (stack.Count>0)
            {
                int smallest = int.MaxValue;
                foreach (var item in stack)
                {
                    if (item == X)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                    if (item < smallest)
                    {
                        smallest = item;
                    }
                }
                Console.WriteLine(smallest);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
