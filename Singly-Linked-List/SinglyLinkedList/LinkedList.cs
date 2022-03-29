using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedLists
{
    public class LinkedList
    {
        Node head;
        public Node Head
        {
            get { return head; }
            set { head = value; }

        }
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }
        public bool Includes(int value)
        {
            Node current = Head;
            int input = value;
            while (current != null)
            {
                if (current.Data == input)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public string ToString()
        {
            Node current = Head;
            string result = "";
            while (current != null)
            {
                result += $"[{current.Data}] -> ";
                current = current.Next;
            }
            return result + "NULL";
        }

    }
}
