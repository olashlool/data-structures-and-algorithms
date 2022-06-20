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
        public Object AddNode(Object value)
        {
            Vertex node = new Vertex(value);
            Vertices.Add(node);
            return node;
        } // Adds a node to the graph.
        public void AddEdge(Vertex vertA, Vertex vertB, int weight)
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
        } // Adds an edge to node which connects to another node or itself, and includes a weight value.
        public List<Vertex> GetNodes()
        {
            if (Vertices.Count == 0)
            {
                return null;
            }
            else
            {
                return Vertices;
            }
        } // Returns a list of nodes within the graph
        public List<Edge> GetNeighbors(Vertex node)
        {
            return Vertices.Find(v => v.Value == node.Value).Edge;
        } // Returns a list of neighbors of a given node
        public int Size()
        {
            return Vertices.Count;
        } // Returns a count of all the nodes in a graph

    }
}
