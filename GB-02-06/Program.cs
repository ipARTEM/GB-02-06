using System;
using System.Collections.Generic;

namespace GB_02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            var v1 = new Node(1);
            var v2 = new Node(2);
            var v3 = new Node(3);
            var v4 = new Node(4);
            var v5 = new Node(5);
            var v6 = new Node(6);
            var v7 = new Node(7);
            var v8 = new Node(8);
            var v9 = new Node(9);

            graph.AddNode(v1);
            graph.AddNode(v2);
            graph.AddNode(v3);
            graph.AddNode(v4);
            graph.AddNode(v5);
            graph.AddNode(v6);
            graph.AddNode(v7);
            graph.AddNode(v8);
            graph.AddNode(v9);

            graph.AddEdge(v1, v2);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v1, v5);
            graph.AddEdge(v1, v9);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v2, v5);
            graph.AddEdge(v5, v6);
            graph.AddEdge(v7, v8);
            graph.AddEdge(v8, v7);
            graph.AddEdge(v9, v8);

            GetMatrix(graph);





            Console.WriteLine();
            Console.WriteLine();

            GetNode(graph, v1);
            GetNode(graph, v2);
            GetNode(graph, v3);
            GetNode(graph, v4);
            GetNode(graph, v5);
            GetNode(graph, v6);
            GetNode(graph, v7);

            Console.WriteLine();

            Console.WriteLine(graph.СonnectionNodes(v1, v5));
            Console.WriteLine(graph.СonnectionNodes(v1, v2));
            Console.WriteLine(graph.СonnectionNodes(v1, v9));

            Console.WriteLine();

            //graph.BFS(graph.GetNodeLists());

            





        }

        

        private static void GetNode(Graph graph, Node node)  // вывод вершины со смежными вершинами
        {
            //Console.WriteLine("           Вывод вершины со смежными вершинами") ;
            Console.Write(node.Number + ": ");
            foreach (var v in graph.GetNodeLists(node))
            {
                Console.Write(v.Number + ", ");

            }
            Console.WriteLine();

        }

        private static void BFS(Graph graph, Node node)
        {

        }

        private static void GetMatrix(Graph graph)  //матрица смежности
        {

            Console.WriteLine("           Матрица смежности");
            Console.WriteLine();
            int[,] matrix = graph.GetMatrix();

            for (int i = 0; i < graph.NodeCount; i++)
            {
                Console.Write("   ");
                Console.Write(i + 1);
                Console.Write("");
            }
            Console.WriteLine();

            for (int i = 0; i < graph.NodeCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < graph.NodeCount; j++)
                {
                    Console.Write("| " + matrix[i, j] + " ");

                }
                Console.WriteLine();
            }
           
        }
    }
}
