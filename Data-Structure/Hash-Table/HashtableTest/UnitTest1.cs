using System;
using Xunit;
using Hash_Table;

namespace HashtableTest
{
    public class UnitTest1
    {
        [Fact]
        public void HashTest01() // Can Successfully Hash A Key To An In Range Value
        {
            Hashtable table = new Hashtable(1024);
            int value = table.Hash("test");
            Assert.True(value < table.Size);
        }
        [Fact]
        public void HashTest02() //Handle A Collision With in A HashTable
        {
            Hashtable table = new Hashtable(1024);

            table.Set("abc", "Some text.");
            table.Set("cba", "Some other text.");

            int value1 = table.Hash("abc");
            int value2 = table.Hash("cba");

            Assert.Equal(value1, value2);
        }
        [Fact]
        public void SetTest() // Can Add Key-Value Pair To HashTable
        {
            Hashtable table = new Hashtable(1024);

            table.Set("abc", "Some text.");

            bool result = table.Contains("abc");

            Assert.True(result);
        }
        [Fact]
        public void GetTest01() // Can Retrieve A Value From A Bucket With Collisions
        {
            Hashtable table = new Hashtable(1024);

            table.Set("abc", "Some text.");
            table.Set("cba", "Some other text.");

            string result1 = table.Get("abc");
            string result2 = table.Get("cba");

            string expected1 = "Some text.";
            string expected2 = "Some other text.";

            Assert.Equal(expected1, result1);
            Assert.Equal(expected2, result2);
        }
        [Fact]
        public void GetTest02() // Can Retrieve Value Based On Key
        {
            Hashtable table = new Hashtable(1024);

            table.Set("abc", "Some text.");

            string result = table.Get("abc");

            string expected = "Some text.";

            Assert.Equal(expected, result);
        }
        [Fact]
        public void ContainsTest() // Can Determine If A Key Exists In A HashTable
        {
            Hashtable table = new Hashtable(1024);

            bool exists = table.Contains("abc");

            Assert.False(exists);
        }
    }
}
