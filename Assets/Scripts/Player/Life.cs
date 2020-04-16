using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    private static int life;
    private static bool isPowerup;


    public static void setLife(int num)
    {
        life = num;
    }

    public static int getLife()
    {
        return life;
    }

    public static void setPowerUp(bool confirm)
    {
        isPowerup = confirm;
    }

    public static bool isPowerUp()
    {
        return isPowerup;
    }

    public static void setLifeChecked()
    {
        PlayerPrefs.SetInt("Life", life);
    }

    public static int getLifeChecked()
    {
        return PlayerPrefs.GetInt("Life");
    }
}
