using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSound : MonoBehaviour
{
    public GameObject soundtrackAudio;
    public string nameSound;

    private void OnEnable()
    {
        SoundManager.playSound(nameSound);
        soundtrackAudio.SetActive(false);
    }
}
