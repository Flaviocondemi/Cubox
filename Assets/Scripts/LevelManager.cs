using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public int scene;
    public static int LEVEL_DONE = 1;
    public static int LEVEL_NOT_DONE = 0;

    public void loads()
    {

        SoundManager.playSound("Touch");
        SceneManager.LoadScene(scene);    
        
    }
    public void Scaling()
    {
        Time.timeScale = 1;
    }

    public static void LevelCompleted(string level)
    {
        PlayerPrefs.SetInt(level, LEVEL_DONE);
    }

    public static void LevelReset(string level)
    {
        PlayerPrefs.SetInt(level, LEVEL_NOT_DONE);
    }

    public static bool isDoneTheLevel(string level)
    {
        if (PlayerPrefs.GetInt(level) == LevelManager.LEVEL_DONE)
            return true;
        else
            return false;

    }
}
