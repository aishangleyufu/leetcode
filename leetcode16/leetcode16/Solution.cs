using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode16
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int res = 0;
            int sumfinal=0;
            Array.Sort(nums);
            int sum = nums[0] + nums[1] + nums[2];
            sumfinal = sum;
            int closet = Math.Abs(sum - target);
            for (int i = 0; i < nums.Length-2; ++i)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];
                    res = Math.Abs(sum - target);
                    if (res < closet)
                    {
                        closet = res;
                        sumfinal = sum;
                    }
                    if (sum < target)
                    {
                        ++left;
                    }
                    else
	                {
                        --right;    
	                }
                }
            }
            return sumfinal;

        }
    }
}
