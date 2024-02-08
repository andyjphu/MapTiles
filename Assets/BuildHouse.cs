using System.Collections;
using System.Collections.Generic;
using cakeslice;
using UnityEngine;

public class BuildHouse : MonoBehaviour
{

    public BuildVariables bv; 
    // Start is called before the first frame update
    void Start()
    {
        bv = GameObject.Find("Global").GetComponent<BuildVariables>(); 
    }

    // Update is called once per frameÏ
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                
                GameObject selectedObject = hit.collider.gameObject;
                if (selectedObject == null) { return; }
                //Debug.Log("Selected Object: " + selectedObject.name);
                bv.clearSelection();
                selectedObject.GetComponent<Outline>().enabled = true; 
                bv.selectedObjects.Add(selectedObject);
                
                

                if (selectedObject.tag == "Tile" && bv.buildHouseEnabled)
                {
                    selectedObject.GetComponent<TileMethods>().updateHouse(true, bv.housePrefab);
                }
            }
        }
    }
}
