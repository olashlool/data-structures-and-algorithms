using System;
using Xunit;
using SinglyLinkedLists;
namespace SinglyLinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestForEmptyList()  // Test empty linked list
        {
            LinkedList list = new LinkedList();
            Assert.Equal("NULL", list.ToString());
        }
        [Fact]
        public void TestForInsertNewValueToStart()    // insert into the linked list && insert multiple nodes into the linked list
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            Assert.Equal("[1] -> NULL", list.ToString());
            list.Insert(2);
            Assert.Equal("[2] -> [1] -> NULL", list.ToString());
        }
        [Fact]
        public void TestIncludes_ReturnTrue()  //return true when finding a value within the linked list that exists
        {
            LinkedList list = new LinkedList();
            list.Insert(22);
            list.Insert(2);
            list.Insert(15);
            bool expected = true;
            Assert.Equal(expected, list.Includes(2));
        }

        [Fact]
        public void TestNOTIncludes_ReturnFalse() // return false when searching for a value in the linked list that does not exist
        {
            LinkedList list = new LinkedList();
            list.Insert(22);
            list.Insert(2);
            list.Insert(15);
            bool expected = false;
            Assert.Equal(expected, list.Includes(3));
        }
        [Fact]
        public void TestAppend()       // Test Add a node to the end of the linked list
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(3);
            list.Insert(2);
            Assert.Equal("[2] -> [3] -> [1] -> NULL", list.ToString());
            list.Append(5);
            Assert.Equal("[2] -> [3] -> [1] -> [5] -> NULL", list.ToString());
        }
        
        [Fact]
        public void TestMultipleAppend()       // Test Append multiple nodes to the end of a linked list
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(3);
            list.Insert(2);
            Assert.Equal("[2] -> [3] -> [1] -> NULL", list.ToString());
            list.Append(20);
            list.Append(5);
            list.Append(21);
            Assert.Equal("[2] -> [3] -> [1] -> [20] -> [5] -> [21] -> NULL", list.ToString());
        }
        [Fact]
        public void TestInsertBefore()       // Test insert a node before a node located i the middle of a linked list
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            Assert.Equal("[1] -> [3] -> [2] -> NULL", list.ToString());
            list.InsertBefore(3, 5);
            Assert.Equal("[1] -> [5] -> [3] -> [2] -> NULL", list.ToString());
        }
        
        [Fact]
        public void TestInsertBeforeFirstNode()       // Test insert a node before the first node of a linked list
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            Assert.Equal("[1] -> [3] -> [2] -> NULL", list.ToString());
            list.InsertBefore(1, 5);
            Assert.Equal("[5] -> [1] -> [3] -> [2] -> NULL", list.ToString());
        }

        
        [Fact]

        public void TestInsertAfter()       // Test insert after a node in the middle of the linked list
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            Assert.Equal("[1] -> [3] -> [2] -> NULL", list.ToString());
            list.InsertAfter(3, 5);
            Assert.Equal("[1] -> [3] -> [5] -> [2] -> NULL", list.ToString());
        }

        
        [Fact]

        public void TestInsertNodeAfterTheLastNode()      //Test insert a node after the last node of the linked list
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            Assert.Equal("[1] -> [3] -> [2] -> NULL", list.ToString());
            list.InsertAfter(2, 5);
            Assert.Equal("[1] -> [3] -> [2] -> [5] -> NULL", list.ToString());
        }
    }
}
