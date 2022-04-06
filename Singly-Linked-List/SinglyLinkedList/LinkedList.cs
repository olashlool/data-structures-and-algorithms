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
            } else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }
        public void Append(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
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
            string result = "Head -> ";
            while (Start != null)
            {
                result += $"[{Start.Data}] -> ";
                Start = Start.Next;
            }
            return result + "NULL";
        }
        public object KthFromEnd(int k)
        {
            try
            {
                if (k < 0) throw new Exception();
                int counter = 0;
                Current = Head;
                // Find length of linked list
                while (Current.Next != null)
                {
                    counter++;
                    Current = Current.Next;
                }
                if (k > counter) throw new Exception();
                //  Console.WriteLine($"Conter :{counter}");
                Current = Head;
                while (counter > k)
                {
                    Current = Current.Next;
                    counter--;
                }
                return Current.Data;
            }
            catch (Exception)
            {
                if (k < 0) return "Ooops, Invalid K";
                else return "Ooops, K Out of Range.";
            }
        }
         public LinkedList ZipLists(LinkedList list1, LinkedList list2)
         {
             list1.Current = list1.Head;
             list2.Current = list2.Head;
            if (list1.Current == null) return list2;
             while (list2.Current != null )
             {
                 Node tempNode = list1.Current.Next;
                 list1.Current.Next = list2.Current;
                 list2.Current = tempNode;
                 list1.Current = list1.Current.Next;
             }
             return list1;
         }
    } 
}
