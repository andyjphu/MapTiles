using UnityEngine;

public class TileMethods : MonoBehaviour
{

    public GameObject house;
    public void updateHouse(bool houseState, GameObject housePrefab)
    {
        Vector3 houseOffset = new Vector3(0, 0.25f, 0);
        if (houseState && house==null)
        {
            house = GameObject.Instantiate(housePrefab, gameObject.transform.position + houseOffset, Quaternion.identity);
            GameObject.Find("Global").GetComponent<BuildVariables>().selectedObjects.Add(house);

            
        }
        else
        {

        }
    }
}