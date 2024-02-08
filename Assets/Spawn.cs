using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Spawn : MonoBehaviour
{

    void Start()
    {

        Tileset ts = new Tileset(new (float, float)[] {
            (0, 0), (1, 0), (0, 1), (1, 1),(2,1), (-1,2),
            (0, -1), (-1, 0), (3,3), (2,3), (3,2), (4,4), (4,5)
        });


    }

    // Update is called once per frame
    void Update()
    {

    }
}
