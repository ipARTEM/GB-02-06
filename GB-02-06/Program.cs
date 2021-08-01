using System;
using System.Collections.Generic;

namespace GB_02_06
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Graph(10); // количество вершин

            BFS();

            Graph(10); // количество вершин

            DFS();



        }


        static Queue<int> queue = new Queue<int>();    // очередь, хранящая номера вершин

        static Random rand = new Random();
        static int visited;
        static bool[] used;
        static int[][] g;

        private static void Graph(int node)
        {
            Console.WriteLine();
            Console.WriteLine(" Построение графа");

             visited = node - 1;

            used = new bool[visited + 1];  //массив отмечающий посещённые вершины
            g = new int[visited + 1][];   //массив содержащий записи смежных вершин

            for (int i = 0; i < visited + 1; i++)
            {
                g[i] = new int[visited + 1];
                Console.Write($"\n({i + 1}) вершина -->[");
                for (int j = 0; j < visited + 1; j++)
                {
                    g[i][j] = rand.Next(0, 2);
                }
                g[i][i] = 0;
                foreach (var item in g[i])
                {
                    Console.Write(" {0}", item);
                }
                Console.Write("]\n");
            }

            used[visited] = true;     //массив, хранящий состояние вершины(посещали мы её или нет)

            queue.Enqueue(visited);
            Console.WriteLine();


        }
        private static void BFS()
        {
            Console.WriteLine("Начинаем обход с {0} вершины", visited + 1);
            
            while (queue.Count != 0)
            {
                visited = queue.Peek();
                queue.Dequeue();
                Console.WriteLine("Перешли к узлу {0}", visited + 1);

                for (int i = 0; i < g.Length; i++)
                {
                    if (Convert.ToBoolean(g[visited][i]))
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            queue.Enqueue(i);
                            Console.WriteLine("Добавили в очередь узел {0}", i + 1);
                        }
                    }
                }
            }
        }

        private static void DFS()
        {
            

        }

        
    }
}
