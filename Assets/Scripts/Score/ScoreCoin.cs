using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCoin : MonoBehaviour
{

    public static int coinScore;

    public static void setMoney()
    {
        coinScore = PlayerPrefs.GetInt("Coin") + 10;
        PlayerPrefs.SetInt("Coin", coinScore);
    }
    public static string getMoney()
    {
        return PlayerPrefs.GetInt("Coin").ToString();
    }

    public static void resetCoin()
    {
        coinScore = 0;
        PlayerPrefs.SetInt("Coin", coinScore);

    }
}
