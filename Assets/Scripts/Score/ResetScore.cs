using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    public string scene;
    public void resetScore()
    {
        LevelManager.LevelReset(scene);
        Score.resetScore("Score" + scene);
    }
}
