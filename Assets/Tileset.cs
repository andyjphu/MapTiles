using System;
using System.Collections.Generic;
using UnityEngine;

public class Tileset
{
    public List<Tile> Tiles = new List<Tile>();
    public Tileset((float, float)[] coordinates)
    {
        HashSet<(float, float)> coordinateSet = new HashSet<(float, float)>();

        foreach ((float x, float z) in coordinates)
        {
            if (!coordinateSet.Contains((x, z)))
            {
                coordinateSet.Add((x, z));
                Tile tile = new Tile(x, z);
                Tiles.Add(tile);
            }
            else {
                Debug.Log($"Duplicate Tile Requested ({x},{z})");
            }
        }
    }
}