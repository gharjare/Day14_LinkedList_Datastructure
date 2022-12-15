using DataStructureLinkedList;

namespace DataStrucureLinkedList
{
    class program
    {
        public static void Main(string[] args)
        {
             LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

            LinkedList1 list1 = new LinkedList1();
            list1.add(70);
            list1.add(30);
            list1.add(56);
            list1.Display();


            LinkedList2 list2 = new LinkedList2();
            list2.append(30);
            list2.append(70);
            list2.append(56);
            list2.Display();

            LinkedList3 list3 = new LinkedList3();
            list3.Add(56);
            list3.Add(30);
            list3.Add(70);
            list3.Display();
            list3.insert();

            LinkedList4 list4 = new LinkedList4();
            list4.Add(56);
            list4.Add(30);
            list4.Add(70);
            list4.Display();
            list4.pop();

            LinkedList5 list5 = new LinkedList5();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.Display();
            list5.popLast();
            
        }
    }
}
