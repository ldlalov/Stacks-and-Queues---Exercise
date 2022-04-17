using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool balanced = true;
            if (input.Length % 2 != 0 || input[0] == ')' || input[0] == '}' || input[0] == ']')
            {
                Console.WriteLine("NO");
                return;
            }
            else
            {
                Stack<string> brackets = new Stack<string>();
                for (int i = 0; i < input.Length; i++)
                {
                    string current = input[i].ToString();
                    switch (current)
                    {
                        case "{":
                            brackets.Push("}");
                            break;
                        case "(":
                            brackets.Push(")");
                            break;
                        case "[":
                            brackets.Push("]");
                            break;
                        case "}":
                            if (brackets.Count>0)
                            {
                            if (brackets.Peek() == "}")
                            {
                            brackets.Pop();
                            }
                            }
                            break;
                        case ")":
                            if (brackets.Count > 0)
                            {
                            if (brackets.Peek() == ")")
                            {
                                brackets.Pop();
                            }
                            }
                            break;
                        case "]":
                            if (brackets.Count > 0)
                            {
                            if (brackets.Peek() == "]")
                            {
                                brackets.Pop();
                            }
                            }
                            break;
                    }
                }
                if (brackets.Count==0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
