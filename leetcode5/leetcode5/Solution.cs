using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode5
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            int le = s.Length;
            bool[,] dp = new bool[le,le];
            int left = 0; int right = 0; int len = 0;
            for (int i = 0; i < le;++i)
            {
                for(int j=0;j<i;++j)
                {
                    dp[j, i] = false;
                    dp[j,i]=(s[i]==s[j]&&((i-j<2)||(dp[j+1,i-1])));
                    if (dp[j,i] && len < i - j + 1)
                    {
                        len = i - j + 1;
                        left = j;
                        right = i;
                    }
                    dp[i, i] = true;
                }
            }
            return s.Substring(left,right-left+1);
        }
    }
}
