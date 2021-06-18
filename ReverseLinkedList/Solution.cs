using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode currentNode = head;
            ListNode temp = null;

            if (head == null) { return null; }
            while (currentNode.next != null)
            {
                temp = currentNode.next;
                currentNode.next = temp.next;
                temp.next = head;
                head = temp;
            }
            return head;


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

   




