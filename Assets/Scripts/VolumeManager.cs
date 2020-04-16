using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour
{
    public static float getVolume()
    {
        return PlayerPrefs.GetFloat("Volume");
    }

    public static void setVolume(float value)
    {
        PlayerPrefs.SetFloat("Volume", value);
    }
}
