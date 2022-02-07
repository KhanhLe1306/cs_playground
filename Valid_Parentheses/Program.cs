using System;
using System.Collections;

namespace Valid_Parentheses

{
    class Program
    {
        static void Main(string[] args)

        {
            string s = "}{";
            bool res = IsValid(s);
            Console.WriteLine(res);
        }

        public static bool IsValid(string s)
        {
            Stack stack = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(c);
                        break;
                    case ')':
                        if (stack.Count != 0 && stack.Pop().ToString() == "(")
                        {
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    case '}':
                        if (stack.Count != 0 && stack.Pop().ToString() == "{")
                        {
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    case ']':
                        if (stack.Count != 0 && stack.Pop().ToString() == "[")
                        {
                            break;
                        }
                        else
                        {
                            return false;
                        }
                }
            }
            return true;
        }
    }
}