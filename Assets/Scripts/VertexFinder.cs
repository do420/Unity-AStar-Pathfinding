using PathFinding;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Diagnostics;
public class VertexFinder : MonoBehaviour
{
    Ray r;
    RaycastHit hit;
    Camera camera;
    int vertexIndex1, vertexIndex2;
<<<<<<< HEAD

    LineRenderer lineRenderer;
    [SerializeField] UIController uiController;
    [SerializeField] Transform sphere1, sphere2;

    bool clicked1 = false, clicked2 = false;

=======
   
    LineRenderer lineRenderer;
    [SerializeField] UIController uiController;
    [SerializeField] Transform sphere1, sphere2;
 
    bool clicked1 = false, clicked2 = false;
  
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
    Mesh mesh;
    Vector3[] vertices;

    List<Node> nodes = new List<Node>();
    List<Edge> edges = new List<Edge>();
    int triangleIndex;
    List<Node> ALL_NODES = new List<Node>();
<<<<<<< HEAD

=======
  
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)

    private void Start()
    {
        mesh = gameObject.GetComponent<MeshFilter>().sharedMesh;
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        lineRenderer = GameObject.FindGameObjectWithTag("LR").GetComponent<LineRenderer>();
        vertices = mesh.vertices;
        triangleIndex = 0;



<<<<<<< HEAD
        for (int i = 0; i < vertices.Length; i++)
=======
        for(int i = 0; i<vertices.Length; i++)
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
        {
            Vector3 point = transform.TransformPoint(vertices[i]);

            var node = new Node(point, i);
            this.nodes.Add(node);
<<<<<<< HEAD

        }
        print("Total node count: " + this.nodes.Count);
        ALL_NODES = nodes;

        for (int i = 0; i < mesh.triangles.Length; i++)
        {
=======
            
        }
        print(this.nodes.Count);
        ALL_NODES = nodes;
        
        for (int i = 0; i < mesh.triangles.Length; i++)
        {



>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
            getNeigbourAndAssign();
        }



<<<<<<< HEAD



        for (int i = 0; i < nodes.Count; i++) //deleting extras
        {
            for (int k = 0; k < nodes[i].Edges.Count; k++)
            {
                if (nodes[i].Edges[k].To.Position == nodes[i].Position)
=======
        
        

        for (int i = 0; i<nodes.Count; i++)
        {
            for(int k = 0; k<nodes[i].Edges.Count; k++)
            {
                if(nodes[i].Edges[k].To.Position == nodes[i].Position)
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
                {
                    nodes[i].Edges.RemoveAt(k);
                }
            }
        }
<<<<<<< HEAD
=======
        
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)




<<<<<<< HEAD


=======
        
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)






    }
    void ShowThePath(List<Node> path)
    {
<<<<<<< HEAD

        lineRenderer.positionCount = 1;
        for (int i = 0; i < path.Count; i++)
        {

            lineRenderer.positionCount += 1;
            lineRenderer.SetPosition(i, path[i].Position);





        }
        lineRenderer.positionCount -= 1;


    }
    void getNeigbourAndAssign()
    {
        if (triangleIndex + 1 > mesh.triangles.Length)
            return;

=======
        
        lineRenderer.positionCount = 0;
        for (int i = 0; i < path.Count; i++)
        {   
            
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(i, path[i].Position);
            
                
            
            
           
        }
        

       
    }
    void getNeigbourAndAssign()
    {
        if (triangleIndex+1 > mesh.triangles.Length)
            return;
        
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
        int[] tri = new int[3] {
                mesh.triangles[triangleIndex + 0],
                mesh.triangles[triangleIndex + 1],
                mesh.triangles[triangleIndex + 2]
        };
<<<<<<< HEAD



        var a = nodes[tri[0]].Connect(nodes[tri[1]], 1);


        var b = nodes[tri[1]].Connect(nodes[tri[2]], 1);


        var c = nodes[tri[2]].Connect(nodes[tri[0]], 1);


=======
       
   
        
        var a = nodes[tri[0]].Connect(nodes[tri[1]]);
      
        var b = nodes[tri[1]].Connect(nodes[tri[2]]);
   
        var c = nodes[tri[2]].Connect(nodes[tri[0]]);
        
    
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)

        edges.Add(a);
        edges.Add(b);
        edges.Add(c);
<<<<<<< HEAD


        triangleIndex += 3;


=======
        

        triangleIndex+=3;
       
       
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)


    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            r = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(r, out hit, 1000))
            {

                ClosestIndexToPoint(r, 1);

            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            r = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(r, out hit, 1000))
            {

                ClosestIndexToPoint(r, 2);

            }
        }
    }

<<<<<<< HEAD

    public void ClosestIndexToPoint(Ray ray, int point)
    {

        RaycastHit hit;

=======
   
    public void ClosestIndexToPoint(Ray ray, int point)
    {
     
        RaycastHit hit;
      
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
        if (Physics.Raycast(ray.origin, ray.direction, out hit))
        {
            Mesh m = hit.transform.GetComponent<MeshFilter>().sharedMesh;
            int[] tri = new int[3] {
                m.triangles[hit.triangleIndex * 3 + 0],
                m.triangles[hit.triangleIndex * 3 + 1],
                m.triangles[hit.triangleIndex * 3 + 2]
<<<<<<< HEAD

            };
            print(m.triangles.Length + " ->" + hit.triangleIndex);



=======
                
            };
            print(m.triangles.Length+ " ->"+ hit.triangleIndex);
            

         
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)


            float closestDistance = Vector3.Distance(m.vertices[tri[0]], hit.point);
            int closestVertexIndex = tri[0];
            for (int i = 0; i < tri.Length; i++)
            {
                float dist = Vector3.Distance(m.vertices[tri[i]], hit.point);
                if (dist < closestDistance)
                {
                    closestDistance = dist;
                    closestVertexIndex = tri[i];
                }
            }



            print(closestVertexIndex);


            Vector3 worldPt = transform.TransformPoint(m.vertices[closestVertexIndex]);

            if (point == 1)
            {
                if (!clicked1)
                    clicked1 = true;
                UpdateDot1(worldPt);
                vertexIndex1 = closestVertexIndex;

            }
            else
            {
                if (!clicked2)
                    clicked2 = true;
                UpdateDot2(worldPt);
                vertexIndex2 = closestVertexIndex;

            }

            if (clicked1 && clicked2)
            {
<<<<<<< HEAD
                UnityEngine.Debug.Log("Two dots have been placed to the scene.");
=======
                UnityEngine.Debug.Log("Two dots have been placed.");
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
                UnityEngine.Debug.Log("Vertex 1 index: " + vertexIndex1 + " Vertex2 index: " + vertexIndex2);
                ShowThePath(PathFinder3000.Search(this.ALL_NODES[vertexIndex1], this.ALL_NODES[vertexIndex2]));
            }

<<<<<<< HEAD

            uiController.SetDistance(PathFinder3000.nodeCount, PathFinder3000.duration);

        }

=======
        
            uiController.SetDistance(PathFinder3000.nodeCount, PathFinder3000.duration);
            
        }
       
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)
    }

    public int getVertexIndex1()
    {
        return vertexIndex1;
    }

    public int getVertexIndex2()
    {
        return vertexIndex2;
    }

<<<<<<< HEAD

=======
    
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)

    void UpdateDot1(Vector3 pos)
    {

<<<<<<< HEAD

=======
       
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)

        sphere1.position = pos;

    }

    void UpdateDot2(Vector3 pos)
    {

<<<<<<< HEAD

=======
        
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)

        sphere2.position = pos;
    }


<<<<<<< HEAD

=======
    public class VertexConnection
    {
        public List<int> connections = new List<int>();
    }
>>>>>>> d69b73fd (Fixed a minor problem with path. Now finds the path with respect to path weight.)


}

