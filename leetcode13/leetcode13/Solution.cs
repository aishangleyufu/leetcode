using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode13
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int res = 0;
            int len = s.Length;
            if (s==null||s.Length==0)
            {
                return -1;
            }
            
            Hashtable ht = new Hashtable();
            ht.Add('I',1);
            ht.Add('V', 5);
            ht.Add('X', 10);
            ht.Add('L', 50);
            ht.Add('C', 100);
            ht.Add('D', 500);
            ht.Add('M', 1000);
            for (int i = 0; i < len; ++i)
            {
                int val = (int)ht[s[i]];
                if (i==len-1||((int)ht[s[i+1]]<=(int)ht[s[i]]))
                {
                    res = res + val;
                }
                else
                {
                    res = res - val;
                }
            }
            return res;
        }
    }
}
