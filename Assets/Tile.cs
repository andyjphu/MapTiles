
using cakeslice;
using UnityEngine;
using System;


public class Tile
{
    private GameObject attachedGameObject;
    private float width = 0.5f;
    private float height = 0;

    public Color baseColor = Color.white;  // Base color for the tile
    public Color fertileColor = Color.green; // Color when fertility is maximum

    public float tileFertility = 0;
    public float maxFertility = 100;


    public void UpdateFertility(float newFertility)
    {
        tileFertility = newFertility;
        tileColor = tileColor;

    }

    public Tile(float centerX, float centerZ)
    {
        InitializeTile(centerX, centerZ, baseColor);
    }

    public Tile(float centerX, float centerZ, Color newColor)
    {
        InitializeTile(centerX, centerZ, newColor);
    }

    private void InitializeTile(float centerX, float centerZ, Color initialColor)
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


        tileColor = initialColor;
        attachedGameObject.GetComponent<MeshRenderer>().material.color = tileColor;
        attachedGameObject.GetComponent<MeshRenderer>().material.SetFloat("_Glossiness", 0);

        attachedGameObject.AddComponent<Outline>();
        attachedGameObject.GetComponent<Outline>().enabled = false;
        attachedGameObject.tag = "Tile";
        attachedGameObject.AddComponent<TileMethods>(); 
        attachedGameObject.transform.position = new Vector3(centerX, height, centerZ);
    }

    public Color tileColor
    {
        get
        {
            // Interpolate between baseColor and fertileColor based on fertility
            float fertilityPercentage = (float)tileFertility / maxFertility;
            return Color.Lerp(baseColor, fertileColor, fertilityPercentage);
        }
        set
        {
            // You can set the color directly if needed
            attachedGameObject.GetComponent<MeshRenderer>().material.color = value;
        }
    }




}
