using System;
using Xunit;
using Tree;
namespace TreeTest
{
    public class BinaryTreeTest
    {
        [Fact]
        public void TestAdd()  //Test instantiate an empty tree
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            Assert.Equal(100, testTree.Root.Value);
        }

        [Fact]
        public void TestAddOrder() //Test instantiate a tree with a single root node
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Root = new Node(5);
            testTree.Add(1);
            Assert.Equal(1, testTree.Root.Left.Value);

        }

        [Fact]
        public void TestMultiAddOrder() //Test multiple add in tree
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            testTree.Add(50);
            testTree.Add(200);
            int[] expected = new int[] { 100, 50,200,};
            int[] results = testTree.PreOrder(testTree.Root);
            Assert.Equal(expected, results);
        }

        [Fact]
        public void TestTrue() // Test Contains return true
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            testTree.Add(50);
            testTree.Add(200);
            Assert.True(testTree.Contains(50));
        }

        [Fact]
        public void TestFalse() // Test Contains return false
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            testTree.Add(50);
            testTree.Add(200);
            Assert.False(testTree.Contains(350));
        }

        [Fact]
        public void TestEmptyTree() // Test Contains for empty tree return false
        {
            BinarySearchTree testTree = new BinarySearchTree();
            Assert.False(testTree.Contains(5));
        }

        [Fact]
        public void TestPreOrder() //Test preorder traversal
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);
            int[] expected = new int[] { 1, 2, 4, 5, 3 };
            Assert.Equal(expected, testTree.PreOrder(testTree.Root));
        }
        [Fact]
        public void TestInOrder()  // Test inorder traversal
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);
            int[] expected = new int[] { 4, 2, 5, 1, 3 };
            Assert.Equal(expected, testTree.InOrder(testTree.Root));
        }
        [Fact]
        public void TestPostOrder()  // Test postorder traversal
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);
            int[] expected = new int[] { 4, 5, 2, 3, 1 };
            Assert.Equal(expected, testTree.PostOrder(testTree.Root));
        }

    }
}
