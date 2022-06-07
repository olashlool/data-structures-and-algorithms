using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class LinkedList
    {
        public Node Head { get; set; } = null;
        public Node Current { get; set; }
        public LinkedList() { } // Constructor method to instantiate an empty LinkedList.
        public LinkedList(Node node) // Constructor method to instantiate a LinkList with a Head Node.
        {
            Head = node;
        }
        public void Append(Node node) // Adds a new Node to the end of the LinkedList.
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = node;
            }
        }
    }
}
