using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
    public class Node
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public Node Next { get; set; } // The next Node in the LinkedList.
        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
