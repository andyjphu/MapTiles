using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableHouse : MonoBehaviour
{
    public bool toggled = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void enablefarm()
    {
        GameObject.Find("Global").GetComponent<BuildVariables>().toggleBuildHouse();
        toggled = !toggled;
        if (toggled == true)
        {

            gameObject.GetComponent<Image>().color = Color.grey;
        }
        else
        {
            gameObject.GetComponent<Image>().color = Color.white;

        }
    }
}
