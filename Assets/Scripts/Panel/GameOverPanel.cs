using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{

    public GameObject soudTrack;
    public GameObject textCountDown;
    public GameObject pauseMenu;
    public string level;

    private void OnEnable()
    {
        Score.resetScore("Score" + level);
        Life.setPowerUp(false); //remove the immunity if you die before the timer is expired.
        TouchControlButton.resetAxisValue();
        SoundManager.playSound("GameOver");
        soudTrack.SetActive(false);
        textCountDown.SetActive(false);
        pauseMenu.SetActive(false);
    }
}
