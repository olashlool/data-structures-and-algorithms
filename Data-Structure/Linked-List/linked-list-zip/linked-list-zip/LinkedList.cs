using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_zip
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }
        public LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            Node listACurrent = list1.Head;
            Node listBCurrent = list2.Head;

            if (listACurrent == null) return list2;
            while (listBCurrent != null)
            {
                Node tempNode = listACurrent.Next;
                listACurrent.Next = listBCurrent;
                listBCurrent = tempNode;
                listACurrent = listACurrent.Next;
            }
            return list1;
        }
        public string ToString()
        {
            Node Start = Head;
            string result = "Head -> ";
            while (Start != null)
            {
                result += $"[{Start.Data}] -> ";
                Start = Start.Next;
            }
            return result + "NULL";
        }
    }
}
