using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    public GameObject soudTrack;
    public GameObject textCountDown;
    public GameObject pauseMenu;

    public string level;

    private void OnEnable()
    {
        TouchControlButton.resetAxisValue();
        LevelManager.LevelCompleted(level);
        SoundManager.playSound("Win");
        soudTrack.SetActive(false);
        textCountDown.SetActive(false);
        pauseMenu.SetActive(false);
    }
}
