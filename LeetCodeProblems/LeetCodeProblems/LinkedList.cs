using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
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
    class LinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode next = null;
            ListNode prev = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;

            }
            return prev;
        }

        public static void PrintList(ListNode head)
        {
            ListNode curr = head;
            while (curr != null)
            {
                Console.Write(curr.val + " ");
                curr = curr.next;
                Console.Write('\n');
            }

        }
    }
}
