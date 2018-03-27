using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode8
{
    public class Solution
    {

        public int MyAtoi(string str)
        {
            string str2 = str.Trim();
            if (string.IsNullOrEmpty(str2)) { return 0; }
            int sign = 1;
            int base1 = 0;
            int base2 = 0;
            int i = 0;
            int n = str2.Length;
            if (str2[i] == '+' || str2[i] == '-')
            {
                sign = (str2[i++] == '+') ? 1 : -1;
            }
            while (i < n && str2[i] >= '0' && str2[i] <= '9')
            {
                if ((base1 > Int32.MaxValue / 10) || (base1 == Int32.MaxValue / 10 && str2[i] - '0' > '7'))
                {
                    return (sign == 1) ? Int32.MaxValue : Int32.MinValue;
                }
                base1 = 10 * base1 + (str2[i++] - '0');

            }
            base2 = base1 * sign;
            if (base2 == -2147483648 && sign == 1) { base2 = 2147483647; }
            if (base2 == 2147483647 && sign == -1) { base2 = -2147483648; }
            return base2;
        }
    }
}
