using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Join
{
    public class Node
    {
        public object Key { get; set; }
        public object Value { get; set; }
        public Node Next { get; set; } // The next Node in the LinkedList.
        public Node(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
