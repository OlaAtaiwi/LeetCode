using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class ValidParentheses
    {
        public static bool IsValid(string str)
        {


            Stack<char> s = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    s.Push(ch);
                }
                else
                {
                    if (s.Count == 0) return false;
                    char top = s.Peek();
                    if (top == '(' && ch == ')') s.Pop();
                    else if (top == '{' && ch == '}') s.Pop();
                    else if (top == '[' && ch == ']') s.Pop();
                    else return false;

                }


            }

            if (s.Count == 0)
                return true;
            else return false;

        }
    }
}
