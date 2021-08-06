using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Leetcode
{
    [DebuggerDisplay("val={val}, next={next}")]
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        #region debug helper
        public ListNode(int[] arr)
        {
            if (arr?.Length > 0)
            {
                val = arr[0];
                var nextArr = arr.ToList().Skip(1).ToArray();
                next = nextArr.Length == 0 ? null : new ListNode(nextArr);
            }
        }

        public int[] ToArray()
        {
            var arr = new List<int> { val };
            var nextNode = next;
            while (nextNode != null)
            {
                arr.Add(nextNode.val);
                nextNode = nextNode.next;
            }

            return arr.ToArray();
        }
        #endregion
    }

    public class LinkedList
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode next = l1;
            int saved = 0;

            do
            {
                next.val = saved + next.val + (l2?.val ?? 0);
                saved = 0;

                if (next.val > 9)
                {
                    saved = next.val / 10;
                    next.val %= 10;
                }

                if (l2 != null)
                    l2 = l2.next;

                // pre-check to avoid null ref assign
                if (next.next == null)
                {
                    next.next = l2; // continue with l2 (if it's available)
                    l2 = null; // end l2 for prevent dup
                }

                next = next?.next; // cont the loop
            } while (next != null);

            if (saved > 0) // this is the last node
            {
                ListNode last = l1;
                while (last.next != null)
                {
                    last = last.next;
                }
                last.next = new ListNode(saved);
            }

            return l1;
        }
    }
}
