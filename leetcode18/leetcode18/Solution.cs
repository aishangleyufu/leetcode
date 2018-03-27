using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode18
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> li = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-3; ++i)
            {
                if (i> 0 && nums[i] == nums[i - 1]) continue;
                for (int j = i+1; j < nums.Length-2; ++j)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                    int left = j + 1;
                    int right = nums.Length - 1;
                    while (left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum == target)
                        {
                            int[] linum = new int[] { nums[i], nums[j], nums[left], nums[right] };
                            li.Add(linum);
                            while (left < right && nums[left] == nums[left + 1]) ++left;
                            while (left < right && nums[right] == nums[right - 1]) --right;
                            ++left;
                            --right;
                        }
                        else if (sum < target)
                        {
                            ++left;
                        }
                        else
                        {
                            --right;
                        }
                    }
                }
            }
            return li;
        }
    }
}
