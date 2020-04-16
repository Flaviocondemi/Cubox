using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{

    public GameObject soudTrack;
    public GameObject textCountDown;
    public GameObject pauseMenu;

    private void OnEnable()
    {
        TouchControlButton.resetAxisValue();
        SoundManager.playSound("GameOver");
        soudTrack.SetActive(false);
        textCountDown.SetActive(false);
        pauseMenu.SetActive(false);
    }
}
