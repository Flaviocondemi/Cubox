using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TouchLayoutManager : MonoBehaviour
{
    private const int LEFT_CONTROL = 0;
    private const int RIGHT_CONTROL = 1;
    private static int controlSwitched;

    public static void setLayoutLeft()
    {
        controlSwitched = LEFT_CONTROL;
        PlayerPrefs.SetInt("Control", controlSwitched);
        
    }
    
    public static void setLayoutRight()
    {
        controlSwitched = RIGHT_CONTROL;
        PlayerPrefs.SetInt("Control", controlSwitched);
    }

    public static int getLayout()
    {
        return PlayerPrefs.GetInt("Control");
    }

}
