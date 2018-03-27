using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode19
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next==null) return null;
            ListNode  pre = head;
            ListNode cur = head;
            for (int i = 0; i < n; i++)
            {
                cur = cur.next;
            }
            if (cur==null)
            {
                return head.next;
            }
            while (cur.next != null)
            {
                cur = cur.next;
                pre = pre.next;
            }
            pre.next = pre.next.next;
            return head;
        }
    }
}
