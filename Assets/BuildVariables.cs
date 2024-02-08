using System.Collections.Generic;
using cakeslice;
using TMPro;
using UnityEngine;

public class BuildVariables : MonoBehaviour
{
    public bool buildHouseEnabled = false;
    public GameObject housePrefab;
    public List<GameObject> selectedObjects;
    public int Food = 5;
    public int FoodIncome = 0;

    public void clearSelection()
    {
        foreach (GameObject gb in selectedObjects)
        {
            gb.GetComponent<Outline>().enabled = false;
        }
        selectedObjects = new List<GameObject>();
    }
    public void toggleBuildHouse()
    {
        buildHouseEnabled = !buildHouseEnabled;
    }

    public void updateFood(int newFood)
    {
        Food = newFood;
        GameObject.Find("FoodText").GetComponent<TMP_Text>().text = Food.ToString();
    }

    void Start()
    {
        updateFood(Food);
        InvokeRepeating("tickUpdate", 0f, 0.5f);

    }


    void tickUpdate()
    { updateFood(Food + FoodIncome);
    }

}