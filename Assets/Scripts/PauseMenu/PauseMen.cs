using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMen : MonoBehaviour
{
    public GameObject panel, controlPanelRight, controlPanelLeft;
    public GameObject textCountDown;
    public GameObject score;

    public void showMenu()
    {
        TouchControlButton.resetAxisValue(); //avoid the player moves alone
        SoundManager.playSound("Touch");
        gameObject.SetActive(false);
        if(TouchLayoutManager.getLayout() == 0)
        {
            controlPanelLeft.SetActive(false);
        }
        else
        {
            controlPanelRight.SetActive(false);
        }

        panel.SetActive(true);
        Time.timeScale = 0f;
        score.SetActive(false);


        if (textCountDown.active == true)
        {
            textCountDown.SetActive(false);
        }
    }
}
