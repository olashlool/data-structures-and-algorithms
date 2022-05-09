using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Tree
{
    public class Node
    {
        public string Value { get; set; }
        public List<Node> Children { get; set; }
        public Node()
        {
            Value = null;
        }
        public Node(string value)
        {
            Value = value;
            Children = new List<Node>();
        }
        public List<string> FizzBuzzTree(Node root)
        {
            List<string> listOfNode = new List<string>();
            if (root == null) return null;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                for (int i = 0; i < queue.Count(); i++)
                {
                    int value = Convert.ToInt32(queue.First().Value);

                    if (value % 15 == 0) listOfNode.Add("FizzBuzz");
                    else if (value % 3 == 0) listOfNode.Add("Fizz");
                    else if (value % 5 == 0) listOfNode.Add("Buzz");
                    else listOfNode.Add(queue.First().Value);

                    Node node = queue.Dequeue();
                    foreach (Node item in node.Children)
                    {
                        queue.Enqueue(item);
                    }
                }
            }
            return listOfNode;
        }
        public List<string> Print(Node root)
        {
            List<string> listOfNode = new List<string>();
            if (root == null) return null;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                for (int i = 0; i < queue.Count(); i++)
                {
                    Node node = queue.Dequeue();
                    listOfNode.Add(node.Value);
                    foreach (Node item in node.Children)
                    {
                        queue.Enqueue(item);
                    }
                }
            }
            return listOfNode;
        }
    }
}
