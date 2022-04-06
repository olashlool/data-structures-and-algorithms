using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Linked_List
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
        public void Reverse()
        {
            Node curr = Head;
            Node prev = null;
            Node next = null;

            if (curr == null) return;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            Head = prev;          
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
