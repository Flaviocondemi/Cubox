using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    public string level; //L1, L2, L3...

    public void resetLevel()
    {
        LevelManager.LevelReset(level);
    }
}
