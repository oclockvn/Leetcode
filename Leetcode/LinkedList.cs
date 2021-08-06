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
    }

    public class LinkedList
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode next = l1;
            ListNode prev = null;
            int saved = 0;

            do
            {
                next.val = saved + next.val + (l2?.val ?? 0);
                saved = 0;

                if (next.val > 9)
                {
                    saved = next.val / 10;
                    next.val = next.val % 10;
                }

                if (l2 != null)
                    l2 = l2.next;

                prev = next;
                next = next.next;
                if (next == null)
                {
                    prev = l2;
                    next = prev;

                    //break;
                    //if (next == null)
                    //    break;
                    //if (l2 != null)
                    //{
                    //    prev = l2;
                    //    //l2.val += saved;
                    //    //if (l2.val > 9)
                    //    //{
                    //    //    saved = l2.val / 10;
                    //    //    l2.val = l2.val % 10;
                    //    //}

                    //    //next = l2;
                    //    next = prev;
                    //    //prev = next;
                    //    //break;
                    //}
                }
                //else
                //{
                //    next = next.next;
                //}

                if (l2 == null)
                {
                    //break;
                }

                //if (next == null && l2 != null)
                //{
                //    next = l2;
                //    break; // cont to l2
                //}

            } while (next != null);

            if (saved > 0)
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
