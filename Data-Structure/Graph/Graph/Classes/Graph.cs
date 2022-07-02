using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        public List<Vertex> Vertices { get; set; } = new List<Vertex>();
        public Object AddNode(Object value)  // Adds a node to the graph.
        {
            Vertex node = new Vertex(value);
            Vertices.Add(node);
            return node;
        }
        public void AddEdge(Vertex vertA, Vertex vertB, int weight) // Adds an edge to node which connects to another node or itself, and includes a weight value.
        {
            if (vertA == vertB)
            {
                Vertex point = Vertices.Find(v => v.Value == vertA.Value);
                Edge edge = new Edge(point, weight);
                Vertices.Find(v => v.Value == vertA.Value).Edge.Add(edge);
                return;
            }

            Vertex pointA = Vertices.Find(v => v.Value == vertA.Value);
            Vertex pointB = Vertices.Find(v => v.Value == vertB.Value);

            Edge edgeA = new Edge(pointB, weight);
            pointA.Edge.Add(edgeA);

            Edge edgeB = new Edge(pointA, weight);
            pointB.Edge.Add(edgeB);
        } 
        public List<Vertex> GetNodes()// Returns a list of nodes within the graph
        {
            if (Vertices.Count == 0)
            {
                return null;
            }
            else
            {
                return Vertices;
            }
        } 
        public List<Edge> GetNeighbors(Vertex node) // Returns a count of all the nodes in a graph
        {
            return Vertices.Find(v => v.Value == node.Value).Edge;
        } 
        public int Size()
        {
            return Vertices.Count;
        }
        public List<Vertex> BreadthFirst(Vertex node)
        {
            Vertex root = Vertices.Find(n => n.Value == node.Value);
            List<Vertex> Vertexs = new List<Vertex>();
            Queue<Vertex> Breadth = new Queue<Vertex>();

            root.Visited = true;
            Breadth.Enqueue(root);

            while (Breadth.Count > 0)
            {
                Vertex front = Breadth.Dequeue();
                Vertexs.Add(front);

                foreach (Edge edge in front.Edge)
                {
                    if (!edge.Neighbor.Visited)
                    {
                        edge.Neighbor.Visited = true;
                        Breadth.Enqueue(edge.Neighbor);
                    }
                }
            }
            return Vertexs;
        }
        public int? BusinessTrip(Graph graph, string[] cities)
        {
            int cost = 0;
            if (cities.Length <= 1)
            {
                return null;
            }
            for (int i = 0; i < cities.Length - 1; i++)
            {
                List<Edge> nodeEdges = graph.GetNeighbors(new Vertex(cities[i]));

                if (!nodeEdges.Exists(n => n.Neighbor.Value.ToString() == cities[i + 1]))
                {
                    return null;
                }
                else
                {
                    cost += nodeEdges.Find(n => n.Neighbor.Value.ToString() == cities[i + 1]).Weight;
                }
            }
            return cost;
        }

        public Stack<Vertex> DepthFirst(Graph graph) // Takes in a graph and returns a list of nodes in pre-order, depth first order.
        {
            if (graph.Vertices.Count == 0)
            {
                return null;
            }
            Stack<Vertex> result = new Stack<Vertex>();
            Vertex root = graph.Vertices[0];

            result = DepthFirstHelper(graph, result, root);
            return result;
        }
        public Stack<Vertex> DepthFirstHelper(Graph graph, Stack<Vertex> stack, Vertex root) // Helper method to DepthFirst() that perfoms pre-order, depth first traversal of a graph and adds its nodes to a list.
        {
            root.Visited = true;
            stack.Push(root);
            foreach (Edge edge in root.Edge)
            {
                if (!edge.Neighbor.Visited)
                {
                    DepthFirstHelper(graph, stack, edge.Neighbor);
                }
            }
            return stack;
        }

    }
}
