using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    public class LinkedList5
    {
        internal Node tail;

        public void Add(int id)
        {
            Node node = new Node(id);
            if (this.tail == null)
            {
                this.tail = node;
            }
            else
            {
                Node temp = tail;
                while (temp.next != null)
                {
                    temp = temp.next;

                    temp.next = node;

                }

            }
            Console.WriteLine("{0} is inserted into linked list", id);
        }
        public void Display()
        {
            Node temp = this.tail;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;

            }
        }

        public Node popLast()
        {
            if(tail == null || tail.next == null)
            {
                return null;
            }
            Node temp = tail;
            while(temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;

            return tail;

          
           
                         
          
                      
           
        }
        
        
    }
}
