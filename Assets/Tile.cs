
using cakeslice;
using UnityEngine;
using System;


public class Tile
{
    public GameObject attachedGameObject;
    private float width = 0.5f;
    private float height = 0;


    public Tile(float centerX, float centerZ, Material tileMaterial)
    {
        attachedGameObject = new GameObject($"Tile ({centerX}, {centerZ})");
        attachedGameObject.AddComponent<MeshFilter>();
        attachedGameObject.AddComponent<MeshRenderer>();

        Vector3[] vertices = new Vector3[]
        {
            new Vector3( - width, 0,  - width),
            new Vector3( + width, 0,  - width),
            new Vector3( + width, 0,  + width),
            new Vector3( - width, 0,  + width)
        };

        attachedGameObject.GetComponent<MeshFilter>().mesh.vertices = vertices;
        int[] triangles = new int[] { 0, 2, 1, 0, 3, 2 };
        attachedGameObject.GetComponent<MeshFilter>().mesh.triangles = triangles;
        attachedGameObject.AddComponent<MeshCollider>();


        attachedGameObject.GetComponent<MeshRenderer>().material = tileMaterial;

        attachedGameObject.AddComponent<Outline>();
        attachedGameObject.GetComponent<Outline>().enabled = false;
        attachedGameObject.tag = "Tile";
        attachedGameObject.AddComponent<TileMethods>(); 
        attachedGameObject.transform.position = new Vector3(centerX, height, centerZ);
    }

    // public Color tileColor
    // {
    //     get
    //     {
    //         // Interpolate between baseColor and fertileColor based on fertility
    //         float fertilityPercentage = (float)tileFertility / maxFertility;
    //         return Color.Lerp(baseColor, fertileColor, fertilityPercentage);
    //     }
    //     set
    //     {
    //         // You can set the color directly if needed
    //         attachedGameObject.GetComponent<MeshRenderer>().material.color = value;
    //     }
    // }




}
