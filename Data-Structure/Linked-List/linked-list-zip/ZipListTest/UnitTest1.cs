using System;
using Xunit;
using linked_list_zip;
namespace ZipListTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestZipLinkedList()
        {
            LinkedList list1 = new LinkedList();
            list1.Insert(1);
            list1.Insert(3);
            list1.Insert(5);
            LinkedList list2 = new LinkedList();
            list2.Insert(2);
            list2.Insert(4);
            list2.Insert(6);
            LinkedList list3 = list1.ZipLists(list1, list2);
            Assert.Equal("Head -> [5] -> [6] -> [3] -> [4] -> [1] -> [2] -> NULL", list3.ToString());
        }
        [Fact]
        public void TestZipLinkedList_ListOneLessThanListTwo()
        {
            LinkedList list1 = new LinkedList();
            list1.Insert(1);
            list1.Insert(3);
            LinkedList list2 = new LinkedList();
            list2.Insert(2);
            list2.Insert(4);
            list2.Insert(6);
            LinkedList list3 = list1.ZipLists(list1, list2);
            Assert.Equal("Head -> [3] -> [6] -> [1] -> [4] -> [2] -> NULL", list3.ToString());
        }
        [Fact]
        public void TestZipLinkedList_ListOneLongerThanListTwo()
        {
            LinkedList list1 = new LinkedList();
            list1.Insert(1);
            list1.Insert(3);
            list1.Insert(5);
            list1.Insert(7);
            LinkedList list2 = new LinkedList();
            list2.Insert(2);
            list2.Insert(4);
            LinkedList list3 = list1.ZipLists(list1, list2);
            Assert.Equal("Head -> [7] -> [4] -> [5] -> [2] -> [3] -> [1] -> NULL", list3.ToString());
        }
        [Fact]
        public void TestZipLinkedList_ListOneNULL()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list2.Insert(2);
            list2.Insert(4);
            LinkedList list3 = list1.ZipLists(list1, list2);
            Assert.Equal("Head -> [4] -> [2] -> NULL", list3.ToString());
        }
        [Fact]
        public void TestZipLinkedList_ListtWONULL()
        {
            LinkedList list1 = new LinkedList();
            list1.Insert(1);
            list1.Insert(3);
            LinkedList list2 = new LinkedList();

            LinkedList list3 = list1.ZipLists(list1, list2);
            Assert.Equal("Head -> [3] -> [1] -> NULL", list3.ToString());
        }
    }
}
