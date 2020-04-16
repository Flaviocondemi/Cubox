using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAlert : MonoBehaviour
{
    public AlertDialog alert;
    public void show()
    {
        alert.openAlertDialog();
    }
}
