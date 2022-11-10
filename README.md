# UnityAStarPathfinding
Shortest (using minimum nodes) path finding with A* algorithm for Unity.


![Ekran Görüntüsü (21)](https://user-images.githubusercontent.com/66875687/201072838-aef14891-767b-4356-8a94-aebf20801ae9.png)
![Ekran Görüntüsü (22)](https://user-images.githubusercontent.com/66875687/201072860-c9a66192-41aa-4845-9bce-b32b60135d96.png)


<h1> Usage (On example 3D human mesh) </h1>

```
List<Node> nodes = new List<Node>();
List<Edge> edges = new List<Edge>();

 for (int i = 0; i < vertices.Length; i++) //add vertices to the nodes list
        {
            Vector3 point = transform.TransformPoint(vertices[i]);
            var node = new Node(point, i);
            this.nodes.Add(node);
        }

//add connections between vertices to the edges list
//...
//...
//...

//Use PathFinder3000's method to find the path.
PathFinder3000.Search(this.ALL_NODES[vertexIndex1], this.ALL_NODES[vertexIndex2])
// (startingNode, destinationNode) as parameters.

//Visualize the path using a line renderer:
ShowThePath(PathFinder3000.Search(this.ALL_NODES[vertexIndex1], this.ALL_NODES[vertexIndex2]));

```

<h1> More information about the A* Algorithm: </h1>
https://en.wikipedia.org/wiki/A*_search_algorithm
