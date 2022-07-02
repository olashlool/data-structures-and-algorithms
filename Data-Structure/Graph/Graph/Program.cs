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
            Console.WriteLine("=============== Breadth First ============");
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

            // <! --------------------------------------------------------------------- >
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("=============== Business Trip ============");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Graph graph2 = new Graph();
            graph2.AddNode("Irbid");
            graph2.AddNode("Amman");
            graph2.AddNode("Zarqa");
            graph2.AddNode("Aqaba");
            graph2.AddNode("Madaba");
            Vertex A2 = new Vertex("Irbid");
            Vertex B2 = new Vertex("Amman");
            Vertex C2 = new Vertex("Zarqa");
            Vertex D2 = new Vertex("Aqaba");
            Vertex E2 = new Vertex("Madaba");
            graph2.AddEdge(A2, B2, 180);
            graph2.AddEdge(A2, C2, 100);
            graph2.AddEdge(B2, C2, 75);
            graph2.AddEdge(C2, D2, 350);
            graph2.AddEdge(C2, E2, 250);
            graph2.AddEdge(D2, E2, 150);

            string[] cities = { "Irbid", "Amman", "Zarqa" };
            var result = graph2.BusinessTrip(graph2, cities);

            Console.WriteLine("Amman -> Zarqa -> Madaba?");
            Console.WriteLine($"${result}");

            // <! --------------------------------------------------------------------- >
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("=============== Depth First ============");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Graph graph3 = new Graph();

            Vertex A3 = new Vertex("A");
            Vertex B3 = new Vertex("B");
            Vertex C3 = new Vertex("C");
            Vertex D3 = new Vertex("D");
            Vertex E3 = new Vertex("E");
            Vertex F3 = new Vertex("F");

            graph3.AddNode("A");
            graph3.AddNode("B");
            graph3.AddNode("C");
            graph3.AddNode("D");
            graph3.AddNode("E");
            graph3.AddNode("F");

            graph3.AddEdge(A3, B3, 4);
            graph3.AddEdge(A3, C3, 6);
            graph3.AddEdge(B3, D3, 22);
            graph3.AddEdge(B3, E3, 5);
            graph3.AddEdge(C3, F3, 15);


            Stack<Vertex> depthFirst = graph3.DepthFirst(graph3);
            Console.Write("Depth first graph: at root A: ");
            foreach (Vertex node in depthFirst)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();
        }
    }
}
