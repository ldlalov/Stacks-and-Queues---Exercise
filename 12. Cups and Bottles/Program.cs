using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));//1-100 integers
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int wasted = 0;
            while (bottles.Count > 0 && cups.Count > 0)
            {
                int currentCup = cups.Peek();
                while (currentCup > 0)
                {
                    int currentBottle = bottles.Pop();
                    currentCup -= currentBottle;
                }
                cups.Dequeue();
                wasted += Math.Abs(currentCup);
            }
            if (bottles.Count>0)
            {
                    Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
                    Console.WriteLine($"Wasted litters of water: {wasted}");
            }
            else
            {
                    Console.WriteLine($"Cups: {string.Join(' ', cups)}");
                    Console.WriteLine($"Wasted litters of water: {wasted}");
            }
        }
    }
}
