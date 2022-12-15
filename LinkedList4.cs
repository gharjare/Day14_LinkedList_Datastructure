using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    public class LinkedList4
    {
        internal Node head;

        public void Add(int id)
        {
            Node node = new Node(id);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                    temp.next = node;

                }

            }
            Console.WriteLine("{0} is inserted into linked list", node.id);
        }
        public void Display()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;

            }
        }

        public void pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("list is empty,Deletion is not possible");
            }
            Console.WriteLine("value popped is {0}", this.head.id);
            this.head = this.head.next;
        }
    }
}
