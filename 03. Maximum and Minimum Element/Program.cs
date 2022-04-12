using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Stack<int> stack1 = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                int[] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();
                 switch (cmd[0])
                {
                    case 1:
                    stack1.Push(cmd[1]);
                        break;
                    case 2:
                        if (stack1.Count>0)
                        {
                        stack1.Pop();
                        }
                        break;
                    case 3:
                        if (stack1.Count>0)
                        {
                        int temp = int.MinValue;
                        foreach (var item in stack1)
                        {
                            if (item>= temp)
                            {
                                temp = item;
                            }
                        }
                        Console.WriteLine(temp);
                        }
                        break;
                    case 4:
                        if (stack1.Count > 0)
                        {
                            int temp = int.MaxValue;
                            foreach (var item in stack1)
                            {
                                if (item <= temp)
                                {
                                    temp = item;
                                }
                            }
                            Console.WriteLine(temp);
                        }
                        break;
                }
            }
            int[] array = stack1.ToArray();
            Console.WriteLine(String.Join(", ",  array));
        }
    }
}
