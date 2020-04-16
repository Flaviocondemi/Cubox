using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillOutObject : MonoBehaviour
{
    public GameObject obj;
    public Transform pos;

    private void Update()
    {
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.transform.position.z);

        Vector3 screenHeight = new Vector3(Screen.width / 2, Screen.height, Camera.main.transform.position.z);

        Vector3 screenWidth = new Vector3(Screen.width, Screen.height / 2, Camera.main.transform.position.z);

        Vector3 goscreen = Camera.main.WorldToScreenPoint(transform.position);

        float distX = Vector3.Distance(new Vector3(Screen.width / 2, 0f, 0f), new Vector3(goscreen.x, 0f, 0f));
        
        float distY = Vector3.Distance(new Vector3(0f, Screen.height / 2, 0f), new Vector3(0f, goscreen.y, 0f));

        if (distX > Screen.width / 2 || distY > Screen.height / 2)
        {
            obj.SetActive(false);
            obj.transform.position = pos.position;
        }
        else
        {
            obj.SetActive(true);
        }
        
    }
    /*private void OnEnable()
    {
        Instantiate(obj, pos);
    }*/
}
