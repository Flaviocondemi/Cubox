using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertDialog : MonoBehaviour
{
    public GameObject alertDialog;

    public void openAlertDialog()
    {
        alertDialog.SetActive(true);
    }

    public void closeAlertDialog()
    {

        alertDialog.SetActive(false);

    }

}