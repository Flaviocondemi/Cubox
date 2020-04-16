using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;

    public static void setScore(string level)
    {
        score = PlayerPrefs.GetInt(level) + 10;
        PlayerPrefs.SetInt(level, score);
    }

    public static void SaveCheckPointScore(string level)
    {
        PlayerPrefs.SetInt(level, score);
    }

    public static string getScore(string level)
    {
        return PlayerPrefs.GetInt(level).ToString();
    }

    public static void resetScore(string level)
    {
        score = 0;
        PlayerPrefs.SetInt(level, score);
    }
}
