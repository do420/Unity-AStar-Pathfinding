using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathFinding;
using Priority_Queue;
using System.Diagnostics;
<<<<<<< HEAD
public class PathFinder3000
=======
public class PathFinder3000 
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
{


    public static long duration;
    public static int nodeCount;
<<<<<<< HEAD



=======
   
   
   
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
    public static List<Node> Search(Node start, Node goal)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start(); //FOR MEASURING TIME


<<<<<<< HEAD
        if (start.Index > goal.Index)
=======
        if(start.Index > goal.Index)
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
        {
            Node temp = start;
            start = goal;
            goal = temp;
        }


<<<<<<< HEAD
        UnityEngine.Debug.Log("Starting idx:" + start.Index + " | Dest.  idx: " + goal.Index);
=======
        UnityEngine.Debug.Log("Starting idx:"+start.Index+" | Dest. idx: "+goal.Index);
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)

        Dictionary<Node, Node> came_from = new Dictionary<Node, Node>();
        Dictionary<Node, float> cost_so_far = new Dictionary<Node, float>();

        List<Node> path = new List<Node>();

        SimplePriorityQueue<Node> frontier = new SimplePriorityQueue<Node>();
        frontier.Enqueue(start, 0);

        came_from.Add(start, start);
        cost_so_far.Add(start, 0);

        Node current = start;
        while (frontier.Count > 0)
        {
            current = frontier.Dequeue();
            if (current == goal) break; // Early exit

            foreach (Edge edge in current.Edges)
            {
                Node next = edge.To;
<<<<<<< HEAD
                float new_cost = cost_so_far[current] + 1;
=======
                float new_cost = cost_so_far[current] + edge.Weight; //cost will be added up to here.
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
                if (!cost_so_far.ContainsKey(next) || new_cost < cost_so_far[next])
                {
                    cost_so_far[next] = new_cost;
                    came_from[next] = current;
<<<<<<< HEAD
                    float priority = new_cost + 1;
=======
                    float priority = new_cost + EstimateCost(next, goal);
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
                    frontier.Enqueue(next, priority);
                    next.Priority = new_cost;
                }
            }
        }

        while (current != start)
        {
            path.Add(current);
            current = came_from[current];
        }
<<<<<<< HEAD
        path.Reverse();
        UnityEngine.Debug.Log("Found the path.");
        UnityEngine.Debug.Log("Node count:" + path.Count);
        nodeCount = path.Count;
        stopwatch.Stop();
        UnityEngine.Debug.Log("A* algorithm calc. duration: " + stopwatch.ElapsedMilliseconds);
        duration = stopwatch.ElapsedMilliseconds;
        return path;
    }
=======
        path.Add(start);
        path.Reverse();
        UnityEngine.Debug.Log("Found the path.");
        UnityEngine.Debug.Log("Node count:" + (path.Count)); 
        nodeCount = path.Count; 
        stopwatch.Stop();
        UnityEngine.Debug.Log("A* algorithm calc. duration: " + stopwatch.ElapsedMilliseconds);
        
        duration = stopwatch.ElapsedMilliseconds;
        UnityEngine.Debug.Log("Total path distance: " + FindTotalPathDistance(path) );
        return path;
    }


    public static float EstimateCost(Node a, Node b) 
    {
        return Vector3.Distance(a.Position, b.Position);
    }
    public static float FindTotalPathDistance(List<Node> thePath) // for testing the distance at the end.
    {
        float dist = 0;
        for(int i = 0; i< thePath.Count-1; i++)
        {
            dist += Vector3.Distance(thePath[i].Position, thePath[i + 1].Position);
        }
        return dist;



    }
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
}
