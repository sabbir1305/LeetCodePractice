using System;

namespace PalindromeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,2,2,1
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(2);
            listNode.next.next.next = new ListNode(1);
            var sln = new Solution();
            if (sln.IsPalindrome(listNode))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
           
        }
    }
}
