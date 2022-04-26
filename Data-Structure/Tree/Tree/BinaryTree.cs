﻿using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<object> ArrayList = new List<object>();

        public BinaryTree(Node node)
        {
            Root = node;
        }

        public BinaryTree()
        {

        }

        public object[] PreOrder(Node root)
        {
            try
            {
                ArrayList.Add(root.Value);

                if (root.Left != null)
                {
                    PreOrder(root.Left);
                }
                if (root.Right != null)
                {
                    PreOrder(root.Right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return ArrayList.ToArray();
        }
      
        public object[] InOrder(Node root)
        {
            try
            {
                if (root.Left != null)
                {
                    InOrder(root.Left);
                }

                ArrayList.Add(root.Value);

                if (root.Right != null)
                {
                    InOrder(root.Right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return ArrayList.ToArray();
        }

        public object[] PostOrder(Node root)
        {
            try
            {
                if (root.Left != null)
                {
                    PostOrder(root.Left);
                }
                if (root.Right != null)
                {
                    PostOrder(root.Right);
                }

                ArrayList.Add(root.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ArrayList.ToArray();
        }
    }
}
