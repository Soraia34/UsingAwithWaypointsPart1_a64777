using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Graph 
{
    List<Edge> edges = new List<Edge>();
    List<Node> nodes = new List<Node>();
    List<Node> pathList = new List<Node>();

    public Graph()
    {
        
    }

    public void addNode(GameObject id)
    {
        Node node = new Node(id);
        nodes.Add(node);
    }

    public void addEdge(GameObject fromNode, GameObject toNode)
    {
        Node from = findNode(fromNode);
        Node to = findNode(toNode);

        if(from != null && to != null)
        {
            Edge e = new Edge(from, to);
            edges.Add(e);
            from.edgeList.Add(e);
        }

    }

    Node findNode(GameObject id)
    {
        foreach(Node n in nodes)
        {
            if(n.getID() == id)
            {
                return n;
            }
        }
        return null;
    }
}
