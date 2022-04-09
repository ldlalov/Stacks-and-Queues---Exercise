using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));

        }
    }
}
