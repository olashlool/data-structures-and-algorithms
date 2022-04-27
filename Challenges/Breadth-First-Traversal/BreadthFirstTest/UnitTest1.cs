using System;
using Xunit;
using Breadth_first_Traversal;
using System.Collections.Generic;

namespace BreadthFirstTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmptyTree()
        {
            Tree tree = new Tree();
            List<int> expected = new List<int> { };
            List<int> results = Program.BreadthFirst(tree.Root);
            Assert.Equal(expected, results);
        }
        [Fact]
        public void TestBalancedTree()
        {
            Tree tree = new Tree();
            tree.Root = (new Node(1));
            tree.Root.Left = (new Node(2));
            tree.Root.Right = (new Node(3));
            tree.Root.Left.Left = (new Node(4));
            tree.Root.Left.Right = (new Node(5));
            tree.Root.Right.Left = (new Node(6));
            tree.Root.Right.Right = (new Node(7));

            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> results = Program.BreadthFirst(tree.Root);
            Assert.Equal(expected, results);
        }
    }
}
