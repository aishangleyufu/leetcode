﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode9
{
   public class Solution
    {
       public bool IsPalindrome(int x)
       {
           if (x < 0) { return false; }
           int div = 1;
           while (x / div >=10) { div = div * 10;}
           while (x > 0)
           {
               int left = x / div;
               int right = x % 10;
               if (left != right) {
                   return false;
               }
               x = (x % div) / 10;
               div = div / 100;
           }
           return true;
       }
    }
}
