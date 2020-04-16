using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointText : MonoBehaviour
{
    public GameObject checkpointText;
    // Start is called before the first frame update
    public string level;

    void Start()
    {
        if(CheckPoint.isSaved(level) == CheckPoint.STATE_SAVED)
        {
            Debug.Log(CheckPoint.isSaved(level));
            checkpointText.SetActive(true);
        }
        else
        {
            Debug.Log(CheckPoint.isSaved(level));
            checkpointText.SetActive(false);
        }
    }
}
