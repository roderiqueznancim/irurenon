using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SimpleMesh : MonoBehaviour
{
    void Start()
    {
        // Create a new mesh
        Mesh mesh = new Mesh();
        mesh.name = "Quad";

        // Define the vertices of the mesh
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(-0.5f, -0.5f, 0), // Bottom-left
            new Vector3(0.5f, -0.5f, 0),  // Bottom-right
            new Vector3(-0.5f, 0.5f, 0),  // Top-left
            new Vector3(0.5f, 0.5f, 0)    // Top-right
        };

        // Define the triangles of the mesh
        int[] triangles = new int[]
        {
            0, 2, 1, // First triangle
            2, 3, 1  // Second triangle
        };

        // Assign the vertices and triangles to the mesh
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        // Recalculate normals for proper lighting
        mesh.RecalculateNormals();

        // Assign the mesh to the MeshFilter component
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = mesh;
    }
}
