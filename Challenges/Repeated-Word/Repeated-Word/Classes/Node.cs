using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeated_Word
{
    public class Node
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Node Next { get; set; } // The next Node in the LinkedList.
        public Node(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
