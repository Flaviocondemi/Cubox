using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanel : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject panel;

    public void changePanel()
    {
        SoundManager.playSound("Touch");
        currentPanel.SetActive(false);
        panel.SetActive(true);
    }
}
