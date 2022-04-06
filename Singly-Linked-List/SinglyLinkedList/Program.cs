using System;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Append(21);
            list.Insert(20);
            Console.WriteLine("Linked List 01");
            Console.WriteLine(list.ToString());
            LinkedList list2 = new LinkedList();
            list2.Insert(22);
            list2.Insert(2);
            list2.Insert(15);
            Console.WriteLine("Linked List 02");
            Console.WriteLine(list2.ToString());
            //list.Append(2);
            //list.Append(22);
            //Console.WriteLine(list1.ToString());
            //list.InsertBefore(2, 15);
            //list.InsertAfter(2, 22);
            //Console.Write("The Kth of Node 2 : ");
            //Console.WriteLine(list.KthFromEnd(2));
            //Console.WriteLine("The Node is Found ? " + list.Includes(22));
            Console.WriteLine();
            LinkedList list3 = list.ZipLists(list, list2);
            Console.WriteLine("Zipped two linked list..");
            Console.WriteLine(list3.ToString());

        }
    }
}
