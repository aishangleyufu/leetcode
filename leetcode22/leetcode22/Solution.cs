using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode22
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> li =new List<string>();
            generateParenthesis_new(n,n,"",li);
            return li;
        }

        private void generateParenthesis_new(int left,int right,string out1,IList<string>res)
        {
            if (left > right) return;
            if (left == 0 && right == 0)
            {
                res.Add(out1);
            }
            else
            {
                if (left > 0) generateParenthesis_new(left - 1, right, out1 + '(', res);
                if (right > 0) generateParenthesis_new(left, right - 1, out1 + ')', res);
            }
        }
    }
}
