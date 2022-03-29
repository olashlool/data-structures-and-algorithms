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
    }
}
