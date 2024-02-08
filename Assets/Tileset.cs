using System.Collections.Generic;
using UnityEngine;

public class Tileset
{
    public List<Tile> Tiles = new List<Tile>();
    public Tileset (List<(float, float)> coordinates) {
        foreach ((float x, float z) in coordinates) {
            Tile tile = new Tile(x,z);
            Tiles.Add(tile);
        }
    }
}