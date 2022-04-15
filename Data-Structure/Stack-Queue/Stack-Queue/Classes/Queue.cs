using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Queue()
        {
            Front = null;
        }
        public void Enqueue(int value)   // adds a new node with that value to the back of the queue
        {
            Node newNode = new Node(value);
            if (Front == null)
            {
                Front = newNode;
                Rear = newNode;
            }
            else
            {
                Rear.Next = newNode;
                Rear = newNode;
            }
        }
        public Node Dequeue()    // Removes the node from the front of the queue
        {
            if (Front != null)
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            else throw new Exception("The Queue is empty!");
        }
        public Node Peek()  // Returns Value of the node located at the front of the queue
        {
            if (Front != null)
            {
                return Front;
            }
            else
            {
                throw new Exception("The Queue is empty!");
            }
        }
        public bool IsEmpty()
        {
            if (Front == null) return true;
            else return false;
        }
    }
}
