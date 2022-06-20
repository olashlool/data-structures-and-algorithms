using System;
using System.Collections.Generic;
using tree_intersection.Classes.BinaryTree;

namespace tree_intersection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(1024);
            BinaryTree testTree1 = new BinaryTree();
            testTree1.Root = new NodeTree(1);
            testTree1.Root.Left = new NodeTree(2);
            testTree1.Root.Right = new NodeTree(3);
            testTree1.Root.Left.Left = new NodeTree(4);
            testTree1.Root.Left.Right = new NodeTree(5);

            BinaryTree testTree2 = new BinaryTree();
            testTree2.Root = new NodeTree(6);
            testTree2.Root.Left = new NodeTree(6);
            testTree2.Root.Right = new NodeTree(3);
            testTree2.Root.Left.Left = new NodeTree(8);
            testTree2.Root.Left.Right = new NodeTree(9);

            IList<int> results = ht.TreeIntersection(testTree1, testTree2);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

        }
    }
}
