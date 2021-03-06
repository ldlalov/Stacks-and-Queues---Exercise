using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int durationGreen = int.Parse(Console.ReadLine());//1-100
            int durationWindow = int.Parse(Console.ReadLine());//0-100
            Queue<string> cars = new Queue<string>();
            int canPass = durationGreen + durationWindow;
            int currentGreen = durationGreen;
            int passed = 0;
            string command;
            while ((command = Console.ReadLine()) != "END")
            {

                if (command != "green")
                {
                        cars.Enqueue(command);
                }
                else
                {
                    while (cars.Count>0)
                    {
                        if (currentGreen>0)
                        {
                        string currentCar = cars.Dequeue();
                        currentGreen -= currentCar.Length;
                        canPass -= currentCar.Length;
                        if (canPass < 0)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar.Substring(currentCar.Length - Math.Abs(canPass), 1)}.");
                            return;
                        }
                        passed++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    canPass = durationGreen + durationWindow;
                    currentGreen = durationGreen;
                }
            }
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passed} total cars passed the crossroads.");
        }
    }
}
