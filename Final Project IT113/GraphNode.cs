using System.Collections.Generic;

public class GraphNode
{
    public string Name { get; set; }
    public List<GraphNode> Neighbors { get; set; }

    public GraphNode(string name)
    {
        Name = name;
        Neighbors = new List<GraphNode>();
    }

    public void AddNeighbor(GraphNode neighbor)
    {
        Neighbors.Add(neighbor);
    }
}
