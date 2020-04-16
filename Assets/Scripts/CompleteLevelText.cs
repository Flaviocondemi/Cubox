using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevelText : MonoBehaviour
{
    public GameObject completeLevelText;
    public string level;

    // Start is called before the first frame update
    void Update()
    {
        if (LevelManager.isDoneTheLevel(level))
        {
            completeLevelText.SetActive(true);
        }
        else
        {
            completeLevelText.SetActive(false);
        }
    }
}
