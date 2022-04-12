using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int biggest = int.MinValue;
            foreach (var item in orders)
            {
                if (item > biggest)
                {
                    biggest = item;
                }
            }
            Console.WriteLine(biggest);
            while (orders.Count > 0)
            {
                if ((qty - orders.Last()) >= 0)
                {
                    qty -= orders.Dequeue();
                }
                else
                {
                    int[] ordersLeft = orders.ToArray();
                    Console.WriteLine($"Orders left: {string.Join(' ',ordersLeft)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
