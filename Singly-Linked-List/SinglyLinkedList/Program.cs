using System;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(22);
            list.Insert(2);
            list.Insert(15);
            list.Append(20);
            list.Append(5);
            list.Append(21);
            Console.WriteLine(list.ToString());
            list.InsertBefore(2, 20);
            list.InsertAfter(22, 21);
            list.Append(5);
            Console.WriteLine(list.ToString());
            Console.WriteLine("The Node is Found ? " + list.Includes(22));
        }
    }
}
