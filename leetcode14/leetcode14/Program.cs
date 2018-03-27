using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode14
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string[] strs1={"7", "", "8"}; 
            string res = sol.LongestCommonPrefix(strs1);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
