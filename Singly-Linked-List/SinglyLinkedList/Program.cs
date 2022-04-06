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
            list.Append(2);
            list.Append(22);
            Console.WriteLine(list.ToString());
            list.InsertBefore(2, 15);
            list.InsertAfter(2, 22);
            Console.Write("The Kth of Node 2 : ");
            Console.WriteLine(list.KthFromEnd(2));
            Console.WriteLine("The Node is Found ? " + list.Includes(22));

        }
    }
}
