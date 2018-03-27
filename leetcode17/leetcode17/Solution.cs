using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode17
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> sli = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return sli;
            }
            string[] dic = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "xyz" };
            for (int i = 0; i < digits.Length; i++)
            {
                string str = dic[digits[i] - '2'];

            }
            return sli;
        }
    }
}
