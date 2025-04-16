using System;

namespace ConsoleApp4
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

    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            Console.WriteLine("Original Linked List:");
            PrintList(head);

            Console.Write("\nEnter N (node to delete from end): ");
            int n = int.Parse(Console.ReadLine());

            head = RemoveNthFromEnd(head, n);

            Console.WriteLine("\nLinked List after deletion:");
            PrintList(head);
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode fast = dummy;
            ListNode slow = dummy;

            for (int i = 0; i <= n; i++)
            {
                fast = fast.next;
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;

            return dummy.next;
        }

        public static void PrintList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val);
                if (current.next != null)
                {
                    Console.Write("->");
                }
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}