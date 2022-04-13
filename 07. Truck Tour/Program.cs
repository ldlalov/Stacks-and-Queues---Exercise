using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Pump
    {
        public Pump(int index, int liters, int distance)
        {
            Index = index;
            Liters = liters;
            Distance = distance;
        }
        public int Index { get; set; }
        public int Liters { get; set; }
        public int Distance { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<Pump> pumps = new Queue<Pump>();
            int truckPetrol = 0;
            int currentDistance = 0;
            int bestPump = -1;
            for (int i = 0; i < pumpsCount; i++)
            {
                int[] cmd = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Pump pump = new Pump(i, cmd[0], cmd[1]);
                pumps.Enqueue(pump);
            }

            while (pumps.Count > 0)
            {
                Queue<Pump> currentCombination = new Queue<Pump>();
                foreach (Pump pump in pumps)
                {
                    currentCombination.Enqueue(pump);
                }
                bestPump = pumps.Peek().Index;
                for (int i = 0; i < pumpsCount; i++)
                {


                    Pump currentPump = currentCombination.Dequeue();
                    truckPetrol += currentPump.Liters;
                    currentDistance += currentPump.Distance;
                    if (currentDistance > truckPetrol)
                    {
                        currentCombination.Enqueue(currentPump);
                    }
                }
                if (currentCombination.Count == 0)
                {
                    Console.WriteLine(bestPump);
                    pumps = currentCombination;
                }
                else
                {
                    pumps.Enqueue(pumps.Dequeue());
                    bestPump = -1;
                    truckPetrol = 0;
                    currentDistance = 0;
                }

            }
        }
    }
}
