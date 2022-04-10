using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            for (int i = 0; i < array[1]; i++)
            {
                queue.Dequeue();
}
            if (queue.Count > 0)
            {
                int smallest = int.MaxValue;
                foreach (var item in queue)
                {
                    if (item == array[2])
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
