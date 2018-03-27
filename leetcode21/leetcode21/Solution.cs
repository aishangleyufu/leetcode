using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode21
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode cur = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.val<l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            if (l1==null)
            {
                cur.next = l2;
            }
            else
            {
                cur.next = l1;
            }
            return dummy.next;
        }
    }
}
