using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode12
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            string res = "";
            char[] roman={'M','D','C','L','X','V','I'};
            int[] value = { 1000, 500, 100, 50, 10, 5, 1 };
            for (int i = 0; i < 7; i=i+2)
            {
                int x = num / value[i];
                if (x<4)
                {
                    for (int j = 1; j <= x; ++j)
                    {
                        res += roman[i];
                    }
                }
                else if (x==4)
                {
                    res = res + roman[i] + roman[i - 1];
                }
                else if (x>4&&x<9)
                {
                    res = res + roman[i - 1];
                    for (int j = 6; j <=x; ++j)
                    {
                        res += roman[i];
                    }
                }
                else if (x == 9)
                {
                    res = res + roman[i] + roman[i - 2];
                }
                num = num % value[i];
            }
            return res;

        }
    }
}
