using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveControlState : MonoBehaviour
{
    public GameObject togLeft;
    public GameObject togRight;

    private void Start()
    {
        if(TouchLayoutManager.getLayout() == 0)
        {
            togRight.GetComponent<Toggle>().isOn = false;
            togLeft.GetComponent<Toggle>().isOn = true;
        }
        else if (TouchLayoutManager.getLayout() == 1)
        {
            togRight.GetComponent<Toggle>().isOn = true;
            togLeft.GetComponent<Toggle>().isOn = false;
        }
    }
}
