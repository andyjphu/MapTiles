using System.Collections.Generic;
using cakeslice;
using UnityEngine;

public class BuildVariables : MonoBehaviour
{
    public bool buildHouseEnabled = false;
    public GameObject housePrefab; 
    public List<GameObject> selectedObjects; 

    public void clearSelection() {
        foreach (GameObject gb in selectedObjects) {
            gb.GetComponent<Outline>().enabled = false; 
        }
        selectedObjects = new List<GameObject>();
    }
}