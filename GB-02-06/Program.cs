using System;
using System.Collections.Generic;

namespace GB_02_06
{
    public class Node //Вершина
    {
        public int Value { get; set; }
        public List<Edge> Edges { get; set; } //исходящие связи
    }

    public class Edge //Ребро
    {
        public int Weight { get; set; } //вес связи
        public Node Node { get; set; } // узел, на который связь ссылается
    }



    class Program
    {

        static void CompleteGraph(int top)        // количество вершин
        {


        }

        static void Main(string[] args)
        {
            int[,] W = new int[N, N]; // Весовая матрица
            Load(W);

            int[,] ostov = new int[N, 2]; // Состояния вершин (просмотрена или не просмотрена)
            int[] a = new int[N];
            int iMin = 0;
            int jMin = 0;
            for (int k = 0; k < N - 1; k++)
            {
                //Поиск ребра с минимальным весом
                int min = Int32.MaxValue;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (a[i] != a[j] && W[i, j] < min)
                        {
                            iMin = i;
                            jMin = j;
                            min = W[i, j];
                        }
                    }
                }

                // Добавление ребра в список выбранных
                ostov[k, 0] = iMin;
                ostov[k, 1] = jMin;
                // Перекрашивание вершин
                int jM = a[jMin], iM = a[iMin];
                for (int i = 0; i < N; i++)
                {
                    if (a[i] == jM)
                        a[i] = iM;
                }
            }
            // Вывод результата
            for (int i = 0; i < N - 1; i++)
                Console.WriteLine($"({ostov[i, 0]}, {ostov[i, 1]}");



        }
    }
}
