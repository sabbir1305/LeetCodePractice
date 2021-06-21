using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLinkedList
{
    class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while(fast!=null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            slow = Reverse(slow);
            fast = head;
            while (slow != null)
            {
                if (slow.val != fast.val)
                {
                    return false;
                }

                slow = slow.next;
                fast = fast.next;
            }

            return true;
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
