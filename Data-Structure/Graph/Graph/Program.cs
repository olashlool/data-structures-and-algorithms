using System;
using System.Collections.Generic;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make some nodes
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");

            // Count the nodes
            Console.WriteLine($"Number of nodes in graph: {graph.Size()}");

            // Make some edges
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            graph.AddEdge(A, B, 15);
            graph.AddEdge(A, C, 7);

            // Get neighbors of node
            Console.WriteLine("Neighbors and weights of node A:");
            List<Edge> resultA = graph.GetNeighbors(A);
            foreach (Edge edge in resultA)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }
            Console.WriteLine("Neighbors and weights of node C:");
            List<Edge> resultC = graph.GetNeighbors(C);
            foreach (Edge edge in resultC)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }

            // Add some more nodes
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");

            // Get list of nodes in graph
            List<Vertex> nodes = graph.GetNodes();
            Console.Write("List of nodes in graph: ");
            foreach (Vertex node in nodes)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // <! --------------------------------------------------------------------- >
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("=============== BreadthFirst =============");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Graph graphBreadth = new Graph();
            graphBreadth.AddNode("A");
            graphBreadth.AddNode("B");
            graphBreadth.AddNode("C");
            graphBreadth.AddNode("D");
            graphBreadth.AddNode("E");
            graphBreadth.AddNode("F");
            Vertex A1 = new Vertex("A");
            Vertex B1 = new Vertex("B");
            Vertex C1 = new Vertex("C");
            Vertex D1 = new Vertex("D");
            Vertex E1 = new Vertex("E");
            Vertex F1 = new Vertex("F");
            graphBreadth.AddEdge(A1, B1, 15);
            graphBreadth.AddEdge(A1, C1, 7);
            graphBreadth.AddEdge(B1, D1, 6);
            graphBreadth.AddEdge(C1, E1, 10);
            graphBreadth.AddEdge(D1, E1, 80);
            graphBreadth.AddEdge(D1, F1, 74);
            graphBreadth.AddEdge(E1, F1, 9999);

            // Get adjacency list from A to F
            List<Vertex> path = graph.BreadthFirst(A);
            Console.Write("Adjecency list of node A: ");
            foreach (Vertex node in path)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
