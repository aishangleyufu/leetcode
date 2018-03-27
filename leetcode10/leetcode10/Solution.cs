using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode10
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                return string.IsNullOrEmpty(s);
            }
            if (p.Length == 1)
            {
                return (s.Length==1&&(s[0]==p[0]||p[0]=='.'));
            }
            if (p[1] != '*')
            {
                if (string.IsNullOrEmpty(s)) return false;
                return (s[0] == p[0] || p[0] == '.') && IsMatch(s.Substring(1),p.Substring(1));
            }
            while (!string.IsNullOrEmpty(s) && (s[0] == p[0] || p[0] == '.'))
            {
                if (IsMatch(s, p.Substring(2))) return true;
                s = s.Substring(1);
            }
            return IsMatch(s, p.Substring(2));
        }
    }
}
