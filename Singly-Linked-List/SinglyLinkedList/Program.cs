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
            Console.WriteLine("The Node is Found ? " + list.Includes(22));
            Console.WriteLine(list.ToString());
        }
    }
}
