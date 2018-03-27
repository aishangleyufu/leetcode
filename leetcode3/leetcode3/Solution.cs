using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace leetcode3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int[] m = new int[256] ;
            for (int i = 0; i < 256; i++) { m[i] = 0; }
            int res=0;int left=0;
            for (int i = 0; i <(int)s.Length; ++i)
            {
                if (m[s[i]] == 0 || m[s[i]] < left)
                {
                    res = Math.Max(res, i - left + 1);
                }
                else
                {
                    left = m[s[i]];
                }
                m[s[i]] = i + 1;
            }
            return res;
        }
    }
}
