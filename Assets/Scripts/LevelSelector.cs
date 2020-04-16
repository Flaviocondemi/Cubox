using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int scene;
    public string level; //L1, L2, L3...
    public AlertDialog alertDialog;

    public void levelSelected()
    {
        if (LevelManager.isDoneTheLevel(level))
        {
            alertDialog.openAlertDialog();
        }
        else
        {
            SceneManager.LoadScene(scene);
        }

    }
}
