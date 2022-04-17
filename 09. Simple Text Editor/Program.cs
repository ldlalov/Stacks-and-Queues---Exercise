using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operations = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < operations; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                switch (cmd[0])
                {
                    case "1":
                        temp.Append(cmd[1]);
                        text.Push(temp.ToString());
                        break;
                    case "2":
                        int count = int.Parse(cmd[1]);
                        temp.Remove(temp.Length - count, count);
                        text.Push(temp.ToString());
                        break;
                    case "3":
                        Console.WriteLine(temp[int.Parse(cmd[1]) -1]);
                        break;
                    case "4":
                        text.Pop();
                        temp.Clear();
                        if (text.Count>0)
                        {
                        temp.Append(text.Peek());
                        }
                        break;
                }
            }
        }
    }
}
