using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadth_first_Traversal
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Queue(Node node)
        {
            Front = Rear=node;
        }
        public void Enqueue(Node node)   // adds a new node with that value to the back of the queue
        {
            if (Front == null)
            {
                Front = node;
            }
            Rear.Next = node;
            Rear = node;
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
            return Front;
        }
    }
}
