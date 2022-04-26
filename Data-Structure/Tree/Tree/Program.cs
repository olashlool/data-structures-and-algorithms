using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeOUTPUT();
            Console.WriteLine();
            BinarySearchTreeOUTPUT();

        }
        public static void BinaryTreeOUTPUT()
        {
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);
            node.Right.Left = new Node(6);
            node.Right.Right = new Node(7);

            BinaryTree tree = new BinaryTree(node);
            BinaryTree tree2 = new BinaryTree(node);

            object[] result = tree.PreOrder(node);
            Console.WriteLine("==========PreOrder==========");
            Console.WriteLine();

            foreach (object i in result)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
            Console.WriteLine();
            tree.ArrayList.Clear();

            

            object[] resultIn = tree.InOrder(node);
            Console.WriteLine("==========InOrder==========");
            Console.WriteLine();

            foreach (object i in resultIn)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
            Console.WriteLine();
            tree.ArrayList.Clear();

            object[] result2 = tree.PostOrder(node);
            Console.WriteLine("==========PostOrder==========");
            Console.WriteLine();

            foreach (object i in result2)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
        }
        public static void BinarySearchTreeOUTPUT()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(22);
            testTree.Add(55);
            testTree.Add(10);
            Console.WriteLine("====== Test Binary Search Tree (Add/Contain) =====");
            object[] results = testTree.PreOrder(testTree.Root);
            foreach (object i in results)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
            Console.WriteLine($"5 is present ? { testTree.Contains(5)}");
            Console.WriteLine($"10 is present ? { testTree.Contains(10)}");
        }
    }
}