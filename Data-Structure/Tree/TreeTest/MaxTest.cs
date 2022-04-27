using System;
using Xunit;
using Tree;

namespace TreeTest
{
    public class MaxTest
    {
        [Fact]
        public void GeneralTest()
        {
            Node node = new Node(1);
            node.Left = new Node(2);
            node.Left.Left = new Node(3);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);
            BinaryTree tree = new BinaryTree(node);

            Assert.Equal(5, tree.FindMaximumValue());
        }
        [Fact]
        public void TestSameValueInTree()
        {
            Node node = new Node(5);
            node.Left = new Node(5);
            node.Left.Left = new Node(2);
            node.Left.Right = new Node(4);
            node.Right = new Node(5);
            BinaryTree tree = new BinaryTree(node);

            Assert.Equal(5, tree.FindMaximumValue());
        }
        [Fact]
        public void TestNegativeValue()
        {
            Node node = new Node(-1);
            node.Left = new Node(-2);
            node.Left.Left = new Node(-3);
            node.Left.Right = new Node(-4);
            BinaryTree tree = new BinaryTree(node);

            Assert.Equal(-1, tree.FindMaximumValue());
        }
       
    }
}
