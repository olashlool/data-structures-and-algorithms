using System;

namespace Reverse_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(5);
            list.Insert(8);
            list.Insert(5);
            list.Insert(10);
            Console.WriteLine(list.ToString()) ;
            Console.WriteLine("List after Reverse....");
            list.Reverse();
            Console.WriteLine(list.ToString());

        }
    }
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int value)
        {
            Data = value;
            Next = null;
        }
    }
}
