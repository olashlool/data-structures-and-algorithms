using System;

namespace linked_list_zip
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(20);
            Console.WriteLine("Linked List 01");
            Console.WriteLine(list.ToString());
            LinkedList list2 = new LinkedList();
            list2.Insert(22);
            list2.Insert(2);
            list2.Insert(15);
            Console.WriteLine("Linked List 02");
            Console.WriteLine(list2.ToString());
            Console.WriteLine();
            LinkedList list3 = list.ZipLists(list, list2);
            Console.WriteLine("Zipped two linked list..");
            Console.WriteLine(list3.ToString());
        }
    }
    
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        /// <summary>
        /// constructor for our nodes
        /// </summary>
        /// <param name="value">the value contained in the node</param>
        public Node(int value)
        {
            Data = value;
            Next = null;
        }
    }
}
