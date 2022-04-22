using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());//0-100
            int size = int.Parse(Console.ReadLine());//1-5000
            Queue<int> bulets = new Queue<int>(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse());//1-100 integers
            Stack<int> locks = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse());//1-100 integers
            int value = int.Parse(Console.ReadLine());//1-100000
            int totalBullets = bulets.Count();
            bool unlocked = false;
            while (bulets.Count > 0)
            {
                for (int i = 0; i < size; i++)
                {
                    int currentBullet = bulets.Dequeue();
                    int currentLock = locks.Peek();
                    if (currentBullet <= currentLock)
                    {
                        Console.WriteLine("Bang!");
                        locks.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                    if (!locks.Any())
                    {
                        unlocked = true;
                        break;
                    }
                    if (!bulets.Any())
                    {
                        break;
                    }
                }
                if (bulets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
                if (unlocked)
                {
                    break;
                }
            }
            if (!unlocked)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int buletsCost = price * (totalBullets - bulets.Count());
                int moneyEarned = value - buletsCost;
                Console.WriteLine($"{bulets.Count()} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
