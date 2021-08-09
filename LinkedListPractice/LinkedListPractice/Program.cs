using System;
using System.Collections.Generic;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null, temp = null;
            int num;

            Console.WriteLine("Enter the values: ");
            
            while(true)
            {
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0) 
                    break;

                if(head == null)
                {
                    head = new Node(num);
                    temp = head;
                }
                else
                {
                    temp.next = new Node(num);
                    temp = temp.next;
                }
            }

            PrintList(head);

            head = ReverseList(head);

            PrintList(head);
        }

        public static void PrintList(Node head)
        {
            while(head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }

        public static Node ReverseList(Node head)
        {
            if (head.next == null)
                return head;

            Node prev = null;
            Node curr = head;
            Node next = head.next;

            while(next != null)
            {
                curr.next = prev;

                prev = curr;
                curr = next;
                next = next.next;
            }

            curr.next = prev;

            return curr;
        }
    }
}
