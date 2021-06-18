using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodes = new ListNode();
            nodes.val = 1;
            nodes.next = new ListNode();
            nodes.next.val = 2;
            Solution solution = new Solution();

            
           var result = solution.ReverseList(nodes);
            Display(result);



        }

        public static void Display(ListNode head)
        {
            if (head == null )
            {
                return ;
            }
            Console.Write(head.val+ "==>");

            Display(head.next);


           
        }
    }
}
