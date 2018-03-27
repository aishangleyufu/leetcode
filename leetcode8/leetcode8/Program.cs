using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode8
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int basete = sol.MyAtoi("2147483648");
            Console.WriteLine(basete);
            Console.ReadKey();
        }
    }
}
