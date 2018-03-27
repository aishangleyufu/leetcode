using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode23
{
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length==0)
            {
                return null;
            }
            int n = lists.Length;
            while(n>1){
                int k=(n+1)/2;
            for (int i = 0; i < n/2; i++)
            {
                lists[i] = mergeTwoLists(lists[i], lists[i + k]);
            }
                n=k;
            }
            return lists[0];

        }

        private ListNode mergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(-1);
            ListNode cur = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
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
            if (l2==null)
            {
                cur.next = l1;
            }
            return head.next;
        } 
    }


}
