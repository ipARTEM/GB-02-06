namespace GB_02_06
{
    public class Edge //Ребро
    {
        public Node From { get; set; }

        public Node To { get; set; }



        public int Weight { get; set; }

        public Edge(Node from, Node to, int weight = 1)
        {
            From = from;
            To = to;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"({From};{To})";
        }

    }
}
