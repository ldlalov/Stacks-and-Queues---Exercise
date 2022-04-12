using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> box = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int racks = 0;
            int currentSum=0;
            while (box.Count > 0)
            {
                if ((currentSum + box.Peek()) <= rackCapacity)
                {
                    currentSum += box.Pop();
                }
                else
                {
                    racks++;
                    currentSum = 0;
                }
            }
            if (currentSum>0)
            {
                racks++;
            }
            Console.WriteLine(racks);
        }
    }
}
