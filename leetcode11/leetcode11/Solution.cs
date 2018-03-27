using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode11
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int res = 0;
            int i = 0;
            int j = height.Length - 1;
            int a=0;
            while (i < j)
            {
                res = Math.Max(res, Math.Min(height[i], height[j])*(j-i));
                a=(height[i] < height[j])? ++i:--j;
            }
            return res;

        }

    }
}
