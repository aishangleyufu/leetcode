using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode15
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> li2 = new List<IList<int>>();
            Array.Sort(nums);
            for (int k = 0; k < nums.Length; ++k)
            {
                if (nums[k] > 0) break;
                if (k > 0 && nums[k] == nums[k - 1]) continue;
                int target = 0 - nums[k];
                int i = k + 1;
                int j = nums.Length - 1;
                while (i < j)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] a=new int[]{nums[k],nums[i],nums[j]};
                        li2.Add(a);
                        while (i < j && nums[i] == nums[i + 1]) ++i;
                        while (i < j && nums[j] == nums[j - 1]) --j;
                    }
                    else if (nums[i] + nums[j] < target)
                    {
                        ++i;
                    }
                    else
                    {
                        --j;
                    }
                }

            }
            return li2;
        }
    }
}
