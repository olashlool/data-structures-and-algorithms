using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedLists
{
    public class Node
    {
        int data;   // the value contained in the node
        Node next; // the pointer to the next node
        public int Data
        {
            get { return data; }
            set { data = value; }

        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        /// <summary>
        /// constructor for our nodes
        /// </summary>
        /// <param name="value">the value contained in the node</param>
        public Node(int value)
        {
            this.data = value;
            next = null;
        }
    }
}
