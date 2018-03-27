using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode14
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string res = "";
            if (Array.Exists(strs,string.IsNullOrEmpty))
            {
                return "";
            }
            for (int j = 0; j < strs[0].Length;j++)
            {
                char c = strs[0][j];
                for (int i = 1; i < strs.Length;i++)
                {
                    if (j>=strs[i].Length||strs[i][j]!=c)
                    {
                        return res;
                    }
                }
                res = res + c;
            }
            return res;
        }
    }
}
