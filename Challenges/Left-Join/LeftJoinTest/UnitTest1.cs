using Left_Join;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeftJoinTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMatch()
        {
            Hashtable tableOne = new Hashtable(1024);
            tableOne.Set("fond", "enamored");

            Hashtable tableTwo = new Hashtable(1024);
            tableTwo.Set("fond", "averse");

            List<string> results = tableOne.LeftJoin(tableOne, tableTwo);

            List<string> expected = new List<string>();
            expected.Add("fond, enamored, averse");

            Assert.Equal(expected, results);
        }

        [Fact]
        public void TestNoMatch()
        {
            Hashtable tableOne = new Hashtable(1024);
            tableOne.Set("outfit", "garb");

            Hashtable tableTwo = new Hashtable(1024);

            List<string> results = tableOne.LeftJoin(tableOne, tableTwo);

            List<string> expected = new List<string>();
            expected.Add("outfit, garb, NULL");

            Assert.Equal(expected, results);
        }

    }
}
