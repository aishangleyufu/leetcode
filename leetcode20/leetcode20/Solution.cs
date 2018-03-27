using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode20
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> parentheses=new Stack<char>();
            bool res=true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]=='('||s[i]=='['||s[i]=='{')
                {
                    parentheses.Push(s[i]);
                }
                else
                {
                    if (parentheses.Count==0)
                    {
                        return false;
                    }
                    if (s[i] == ')' && parentheses.First()!= '(') return false;
                    if (s[i] == ']' && parentheses.First() != '[') return false;
                    if (s[i] == '}' && parentheses.First() != '{') return false;
                    parentheses.Pop();
                }
            }
            if (parentheses.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
;