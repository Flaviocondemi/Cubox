using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleCheck : MonoBehaviour
{
    public Toggle tog;

    //Use buttons linked to this
    public void ChangeValueToFalse()
    {
        tog.isOn = false;
    }

}
