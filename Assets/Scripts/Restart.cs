using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public string level;
    public void restart()
    {
        CheckPoint.UnsavePlayer(level);
        Score.resetScore("Score" + level);
    }
}
