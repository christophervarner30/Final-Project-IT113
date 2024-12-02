using System;
using System.Collections.Generic;

public class Graph
{
    private Dictionary<string, GraphNode> nodes;

    public Graph()
    {
        nodes = new Dictionary<string, GraphNode>();
    }

    public void AddNode(string name)
    {
        if (!nodes.ContainsKey(name))
        {
            nodes[name] = new GraphNode(name);
        }
    }

    public void AddEdge(string from, string to)
    {
        if (nodes.ContainsKey(from) && nodes.ContainsKey(to))
        {
            nodes[from].AddNeighbor(nodes[to]);
        }
        else
        {
            Console.WriteLine($"Error: One or both nodes '{from}' or '{to}' do not exist.");
        }
    }

    public void DisplayGraph()
    {
        foreach (var node in nodes.Values)
        {
            Console.Write($"{node.Name}: ");
            foreach (var neighbor in node.Neighbors)
            {
                Console.Write($"{neighbor.Name} ");
            }
            Console.WriteLine();
        }
    }

    public void BreadthFirstSearch(string startNode)
    {
        if (!nodes.ContainsKey(startNode))
        {
            Console.WriteLine($"Error: Start node '{startNode}' does not exist.");
            return;
        }

        var visited = new HashSet<string>();
        var queue = new Queue<GraphNode>();

        queue.Enqueue(nodes[startNode]);
        visited.Add(startNode);

        Console.WriteLine("Breadth-First Search Traversal:");
        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            Console.WriteLine(currentNode.Name);

            foreach (var neighbor in currentNode.Neighbors)
            {
                if (!visited.Contains(neighbor.Name))
                {
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor.Name);
                }
            }
        }
    }
}