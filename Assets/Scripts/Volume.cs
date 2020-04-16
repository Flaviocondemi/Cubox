using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    private const int MAX_VOLUME = 1;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = MAX_VOLUME;
    }

    private void Update()
    {
        audioSource.volume = VolumeManager.getVolume();
    }
}
