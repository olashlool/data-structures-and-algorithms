using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Node
    {
        public object Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(object value)
        {
            Value = value;
        }
    }
}
