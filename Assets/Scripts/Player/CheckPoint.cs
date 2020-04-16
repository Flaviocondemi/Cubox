using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private static int state = 0;
    public const int STATE_SAVED = 1;
    public const int STATE_UNSAVED = 0;

    public static void SavePlayer(string level)
    {
       state = STATE_SAVED;
       PlayerPrefs.SetInt("CheckPoint" + level, state);
        
    }

    public static void UnsavePlayer(string level)
    {
        state = STATE_UNSAVED;
        PlayerPrefs.SetInt("CheckPoint" + level, state);
    }

    public static int isSaved(string level)
    {
        return PlayerPrefs.GetInt("CheckPoint" + level);
    }
}
