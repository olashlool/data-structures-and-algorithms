using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection.Classes.BinaryTree
{
    public class NodeTree
    {
        public int Value { get; set; }
        public NodeTree Right { get; set; }
        public NodeTree Left { get; set; }

        /// <summary>
        /// Set value of Node and Left/Right to null
        /// </summary>
        /// <param name="value">Value of Node</param>
        public NodeTree(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
