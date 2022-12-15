using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    public class LinkedList1
    {
        internal Node head;
        public LinkedList1()
        {
            this.head = null;
        }

        public void add(int id)
        {
            Node node = new Node(id);
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;

                
            }
            Console.WriteLine("{0} is inserted into linked list", id);
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
    }
}
