using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;

namespace Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);
            node.Right.Left = new Node(6);
            node.Right.Right = new Node(7);

            BinaryTree tree = new BinaryTree(node);

            BinaryTreeOUTPUT();
            Console.WriteLine($"========= The Maximum Value Tree is ({tree.FindMaximumValue()})===========");
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

            int[] result = tree.PreOrder(node);
            Console.WriteLine("==========PreOrder==========");
            Console.WriteLine();

            foreach (object i in result)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
            Console.WriteLine();
            tree.ArrayList.Clear();

            

            int[] resultIn = tree.InOrder(node);
            Console.WriteLine("==========InOrder==========");
            Console.WriteLine();

            foreach (object i in resultIn)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
            Console.WriteLine();
            tree.ArrayList.Clear();

            int[] result2 = tree.PostOrder(node);
            Console.WriteLine("==========PostOrder==========");
            Console.WriteLine();

            foreach (object i in result2)
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
        public static void BinarySearchTreeOUTPUT()
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(22);
            testTree.Add(55);
            testTree.Add(10);
            Console.WriteLine("====== Test Binary Search Tree (Add/Contain) =====");
            int[] results = testTree.PreOrder(testTree.Root);
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