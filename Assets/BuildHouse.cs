using System.Collections;
using System.Collections.Generic;
using cakeslice;
using UnityEngine;

public class BuildHouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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
                selectedObject.GetComponent<Outline>().enabled = !selectedObject.GetComponent<Outline>().enabled;

                Debug.Log($"{selectedObject.GetComponent<Outline>()}");

                if (selectedObject.tag == "Tile" && GameObject.Find("Global").GetComponent<BuildVariables>().buildHouseEnabled)
                {
                    selectedObject.GetComponent<TileMethods>().updateHouse(true, GameObject.Find("Global").GetComponent<BuildVariables>().housePrefab);
                }
            }
        }
    }
}
