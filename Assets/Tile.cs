
using UnityEngine;

public class Tile
{

    private GameObject attachedGameObject; 
    private float width = 0.5f; 
    private float height = 0; 


    public Tile(float centerX, float centerZ)
    {
        attachedGameObject = new GameObject($"Tile ({centerX}, {centerZ})");
        attachedGameObject.AddComponent<MeshFilter>();
        attachedGameObject.AddComponent<MeshRenderer>();
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(centerX - width, height, centerZ - width),
            new Vector3(centerX + width, height, centerZ - width),
            new Vector3(centerX + width, height, centerZ + width),
            new Vector3(centerX - width, height, centerZ + width)
        };

        attachedGameObject.GetComponent<MeshFilter>().mesh.vertices = vertices;
        int[] triangles = new int[] { 0, 2, 1, 0, 3, 2 };
        attachedGameObject.GetComponent<MeshFilter>().mesh.triangles = triangles;
        attachedGameObject.GetComponent<MeshRenderer>().material.color = Color.white;


    }

}
