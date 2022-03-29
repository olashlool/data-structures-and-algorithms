using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedLists
{
    public class LinkedList
    { 
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Node Current { get; set; }
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }
        public void Append(int value)
        {
            Node newNode = new Node(value);
            if (Head== null)
            {
                Insert(value);
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            
        }
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;
            if (Current != null)
            {
                if (Current.Data == value)
                {
                    Insert(newValue);
                    return;
                }
                while (Current.Next != null)
                {
                    if (Current.Next.Data == value)
                    {
                        Node newNode = new Node(newValue);
                        newNode.Next = Current.Next;
                        Current.Next = newNode;
                        return;
                    }
                    Current = Current.Next;
                }
                Console.WriteLine($"Node {value} not in list");
            }
            else
            {
                Console.WriteLine("List is empty...");
            }
        }
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;
            if (Current != null)
            {
                while (Current.Next != null)
                {
                    if (Current.Data == value)
                    {
                        Node newNode = new Node(newValue);
                        newNode.Next = Current.Next;
                        Current.Next = newNode;
                        return;
                    }
                    Current = Current.Next;
                }
                if (Current.Data == value)
                {
                    Node newNode = new Node(newValue);
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Console.WriteLine($"Node {value} not in list");
            }
            else
            {
                Console.WriteLine("List is empty...");
            }
        }
       
        public bool Includes(int value)
        {
            Current = Head;
            int input = value;
            while (Current != null)
            {
                if (Current.Data == input)
                {
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }
        public string ToString()
        {
            Node Start = Head;
            string result = "";
            while (Start != null)
            {
                result += $"[{Start.Data}] -> ";
                Start = Start.Next;
            }
            return result + "NULL";
        }

    }
}
