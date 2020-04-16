using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    public GameObject pauseIcon;
    public GameObject panel;
    public GameObject controlPanelRight;
    public GameObject controlPanelLeft;
    public GameObject score;

    public void showMenu()
    {
        SoundManager.playSound("Touch");
        panel.SetActive(false);
        pauseIcon.SetActive(true);
        if (TouchLayoutManager.getLayout() == 0)
        {
            controlPanelLeft.SetActive(true);
        }
        else 
        {
            controlPanelRight.SetActive(true);
        }

        Time.timeScale = 1f;
        score.SetActive(true);


        
    }
}

