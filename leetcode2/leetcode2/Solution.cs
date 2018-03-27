using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace leetcode2
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = new ListNode(-1);
            ListNode cur = res;
            int carry = 0;
            while (l1!=null || l2!=null)
            {
                int d1 = l1 == null ? 0 : l1.val;
                int d2 = l2 == null ? 0 : l2.val;
                int sum = d1 + d2 + carry;
                carry = sum >=10?1:0;
                cur.next = new ListNode(sum % 10);
                cur = cur.next;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }
            if (carry == 1) cur.next = new ListNode(1);
            return res.next;
        }
    }
}
