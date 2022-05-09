using FizzBuzz_Tree;
using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz_Tree_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestFizzBuzz()
        {
            Node root = new Node("15");
            root.Children.Add(new Node("2"));
            root.Children.Add(new Node("22"));
            root.Children.Add(new Node("21"));
            root.Children[0].Children.Add(new Node("25"));
            root.Children[0].Children.Add(new Node("30"));
            root.Children[0].Children.Add(new Node("35"));
            root.Children[1].Children.Add(new Node("8"));
            root.Children[2].Children.Add(new Node("9"));
            root.Children[2].Children.Add(new Node("10"));
            root.Children[2].Children.Add(new Node("19"));

            List<string> list = root.FizzBuzzTree(root);
            Assert.Equal(new List<string> { "FizzBuzz", "2", "22", "Fizz", "Buzz", "FizzBuzz", "Buzz", "8", "Fizz", "Buzz", "19" }, list);
        }
        [Fact]
        public void TestNegativTree()
        {
            Node root = new Node("-15");
            root.Children.Add(new Node("2"));
            root.Children.Add(new Node("22"));
            root.Children.Add(new Node("21"));
            root.Children[0].Children.Add(new Node("-25"));
            root.Children[0].Children.Add(new Node("-30"));

            List<string> list1 = root.FizzBuzzTree(root);
            Assert.Equal(new List<string> { "FizzBuzz", "2", "22", "Fizz", "Buzz", "FizzBuzz" }, list1);
        }
    }
}
