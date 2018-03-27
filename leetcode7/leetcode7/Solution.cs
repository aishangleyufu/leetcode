using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode7
{
    public class Solution
    {
        public int Reverse(int x)
        {
            long res=0;
            while(x!=0){
                res=res*10+x%10;
                x=x/10;
            }
            return (int)((res>int.MaxValue||res<int.MinValue)?0:res);
        }
    }
}
