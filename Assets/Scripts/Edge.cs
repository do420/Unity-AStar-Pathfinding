using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PathFinding
{

    public class Edge {

        public Node From { get { return from; } }
        public Node To { get { return to; } }
        public float Weight { get { return weight; } }

        protected Node from, to;
        protected float weight = 0f;

<<<<<<< HEAD
        public Edge (Node n0, Node n1, float w = 1f)
        {
            from = n0;
            to = n1;
            weight = w;
=======
        public Edge (Node n0, Node n1)
        {
            from = n0;
            to = n1;
            weight = Vector3.Distance(n0.Position, n1.Position);
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
        }

        public Node Neighbor(Node node)
        {
            if (from == node) return to;
            return from;
        }

        public bool Has(Node node)
        {
            return (from == node) || (to == node);
        }

        public override string ToString()
        {
            return (from.Position + " - " + to.Position);
        }
    }

}


