using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BinarySearchTree :BinaryTree
    {
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (Root == null)
            {
                Root = newNode;
            }
            Node current = Root;
            Node parent = null;

            while (current != null)
            {
                if (value == (int)current.Value)
                {
                    return;
                }
                else if (value < (int)current.Value)
                {
                    parent = current;
                    current = current.Left;
                }
                else
                {
                    parent = current;
                    current = current.Right;
                }
            }

            if (value < (int)parent.Value)
            {
                parent.Left = newNode;
            }
            else
            {
                parent.Right = newNode;
            }
        }
       
        public bool Contains(int value)
        {
            Node current = Root;
            while (current != null)
            {
                if ((int)current.Value == (int)value)
                {
                    return true;
                }
                else if ((int)value < (int)current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }
    }
}
