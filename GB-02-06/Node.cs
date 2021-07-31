using System.Collections.Generic;

namespace GB_02_06
{
    public class Node //Вершина
    {
        public int Number { get; set; }
        
        public Node(int number)
        {
            Number = number;
        }

        //public override string ToString()
        //{
        //    return Number.ToString();
        //}
    }
}
