using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layout : MonoBehaviour
{

    public GameObject ControlPanelRight;
    public GameObject ControlPanelLeft;

    // Start is called before the first frame update
    void Start()
    {
        if(TouchLayoutManager.getLayout() == 0)
        {
            ControlPanelLeft.SetActive(true);
            ControlPanelRight.SetActive(false);
        }

        if (TouchLayoutManager.getLayout() == 1)
        {
            ControlPanelRight.SetActive(true);
            ControlPanelLeft.SetActive(false);
        }
    }
}
