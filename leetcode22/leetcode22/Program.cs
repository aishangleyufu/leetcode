using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=3;
            IList<string> li = new List<string>();
            generateParenthesis_new1(n, n, "", li);
        }
        public static void generateParenthesis_new1(int left,int right,string out1,IList<string>res)
        {
            if (left > right) return;
            if (left == 0 && right == 0)
            {
                res.Add(out1);
            }
            else
            {
                if (left > 0) generateParenthesis_new1(left - 1, right, out1 + '(', res);
                if (right > 0) generateParenthesis_new1(left, right - 1, out1 + ')', res);
            }
        }


    }


           
}
