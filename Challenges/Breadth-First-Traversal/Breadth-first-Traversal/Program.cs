using System;
using System.Collections.Generic;

namespace Breadth_first_Traversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Root = (new Node(1));
            tree.Root.Left = (new Node(2));
            tree.Root.Right = (new Node(3));
            tree.Root.Left.Left = (new Node(4));
            tree.Root.Left.Right = (new Node(5));
            tree.Root.Right.Left = (new Node(6));
            tree.Root.Right.Right = (new Node(7));

            BreadthFirst(tree.Root);
        }
        public static List<int> BreadthFirst(Node tree)
        {
            List<int> values = new List<int>();
            Queue breadth = new Queue(tree);
            while (breadth.Peek() != null)
            {
                var Front = breadth.Dequeue();
                values.Add(Front.Value);
                Console.Write($"[{Front.Value}] ");
                if (Front.Left != null)
                {
                    breadth.Enqueue(Front.Left);
                }
                if (Front.Right != null)
                {
                    breadth.Enqueue(Front.Right);
                }
            }
            return values;
        }
    }
}
