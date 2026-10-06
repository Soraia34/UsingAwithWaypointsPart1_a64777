using UnityEngine;

public class Edge
{
   public Node startNode;
    public Node endNode;
    
     public Edge(Node form, Node to)
     {
          startNode = form;
          endNode = to;
     }
}
