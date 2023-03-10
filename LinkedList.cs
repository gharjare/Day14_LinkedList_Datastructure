using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureLinkedList
{
    public class LinkedList
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
    }
}
