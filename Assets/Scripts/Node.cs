using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace PathFinding
{

    public class Node {

        public int Index { get { return index; } }
        public Vector3 Position { get { return position; } }
        public List<Edge> Edges { get { return edges; } }
        public float Priority;

        protected Vector3 position;
        public List<Edge> edges;
        protected int index;
        // for path finding
        public float distance;
        public Node prev = null;

        public Node(Vector3 p, int idx) {
            position = p;
            edges = new List<Edge>();
            index = idx;
        }

<<<<<<< HEAD
        public Edge Connect(Node node, float weight = 1f)
        {
            var e = new Edge(this, node, weight);
=======
        public Edge Connect(Node node)
        {
            var e = new Edge(this, node);
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
            edges.Add(e);
            node.edges.Add(e);
           
            return e;
        }
        public int CompareTo(Node other)
        {
            if (this.Priority < other.Priority) return -1;
            else if (this.Priority > other.Priority) return 1;
            else return 0;
        }

    }

}


