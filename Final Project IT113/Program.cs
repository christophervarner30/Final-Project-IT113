using System;

namespace GraphNetworkTopology
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment near main function
            /*
             * Structure/Algorithm/Pattern: Graph Data Structure
             * Project Aim: To demonstrate the representation of a network topology using a graph structure and traversal using BFS.
             * Failure Situations: May fail with extremely large graphs due to memory constraints or unoptimized traversal algorithms.
             * Exceed Expectations: Handles small to medium-sized networks efficiently and demonstrates clear traversal paths.
             */

            // Create a new graph
            Graph network = new Graph();

            // Add nodes (representing devices in the network)
            network.AddNode("Router");
            network.AddNode("Switch");
            network.AddNode("PC1");
            network.AddNode("PC2");
            network.AddNode("Server");

            // Add edges (connections between devices)
            network.AddEdge("Router", "Switch");
            network.AddEdge("Switch", "PC1");
            network.AddEdge("Switch", "PC2");
            network.AddEdge("Switch", "Server");

            // Display the graph
            Console.WriteLine("Network Topology:");
            network.DisplayGraph();

            Console.WriteLine();

            // Perform Breadth-First Search starting from the Router
            network.BreadthFirstSearch("Router");

            Console.ReadKey(); // Wait for user input before closing the console
        }
    }
}