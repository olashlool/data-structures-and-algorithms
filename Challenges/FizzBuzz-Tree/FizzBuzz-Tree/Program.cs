using System;
using System.Collections.Generic;

namespace FizzBuzz_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node("15");
            root.Children.Add(new Node("2"));
            root.Children.Add(new Node("22"));
            root.Children.Add(new Node("21"));
            root.Children[0].Children.Add(new Node("25"));
            root.Children[0].Children.Add(new Node("30"));
            root.Children[0].Children.Add(new Node("35"));
            root.Children[1].Children.Add(new Node("8"));
            root.Children[2].Children.Add(new Node("19"));

            List<string> list = root.Print(root);
            foreach (string item in list)
            {
                Console.Write("[");
                Console.Write(item);
                Console.Write("]");
                Console.Write("=> ");
            }
            Console.WriteLine("NULL");


            Console.WriteLine();

            List<string> list2 = root.FizzBuzzTree(root);
            foreach (string item in list2) 
            {
                Console.Write("[");
                Console.Write(item);
                Console.Write("]");
                Console.Write("=> ");
            }
            Console.WriteLine("NULL");
        }
    }
}
