using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_02_06
{
    class Graph
    {
        List<Node> Nodes = new List<Node>();
        List<Edge> Edges = new List<Edge>();

        public int NodeCount => Nodes.Count;
        public int EdgeCount => Edges.Count;

        public void AddNode(Node node)
        {
            Nodes.Add(node);
        }

        public void AddEdge(Node from, Node to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);

        }

        public int[,] GetMatrix()
        {
            var matrix = new int[Nodes.Count, Nodes.Count];

            foreach (var edge in Edges)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight;

            }

            return matrix;
        }

        public List<Node> GetNodeLists(Node node)
        {
            var result = new List<Node>();

            foreach (var edge in Edges)
            {
                if (edge.From == node)
                {
                    result.Add(edge.To);

                }

            }
            return result;
        }

        public bool СonnectionNodes(Node start, Node finish)
        {     

            var list = new List<Node>
            {
                start
            };

            for (int i = 0; i < list.Count; i++)
            {
                var node = list[i];
                foreach (var v in GetNodeLists(node))
                {
                    if (!list.Contains(v))
                    {
                        list.Add(v);

                    }
                }

            }
            return list.Contains(finish);
        }

        public void BFS(List<Node> nodes)
        {
            Queue<List<Node>> bfs = new Queue<List<Node>>();

            bfs.Enqueue(nodes);

            while (bfs.Count>0)
            {
                nodes = bfs.Dequeue();
                Console.WriteLine(bfs);

            }


        }


    }
}
