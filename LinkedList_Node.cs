using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList_Node
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                 Node temp = head;
                 while(temp.next  != null)
                {
                    temp = temp.next;
                }
                 temp.next = node;
            }
            Console.WriteLine("Linked List " + data);
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }
        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
            }
            if (head.next == null)
            {
                Console.WriteLine("only one element is present");
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("removed last element");
            }
        }

        public void Size()
        {
            if  (head == null)
            {
                Console.WriteLine("The list is emplty");
            }
            Node temp = head;
            int count = 0;
            while(temp != null)
            {
                count++;
                temp = temp.next;
                
            }
            Console.WriteLine("the size of the list is: " + count);
        }
        public int Search(int value)
        {
            Node node = head;
            if(head == null)
            {
               return -1;
            }
            int count = 0;
            while(node != null)
            {
                if(node.data == value)
                {
                    Console.WriteLine(value);
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        
    }
}
