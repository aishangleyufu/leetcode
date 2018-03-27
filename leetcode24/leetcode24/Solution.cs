using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode24
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(-1);
            ListNode cur = dummy;
            dummy.next = head;
            while (cur.next!=null&&cur.next.next!=null)
            {
                ListNode t = cur.next.next;
                cur.next.next = t.next;
                t.next = cur.next;
                cur.next = t;
                cur = t.next;
            }
            return dummy.next;
        }
    }
}
