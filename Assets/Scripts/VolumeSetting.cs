using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    Slider slider;
    private float volumeSelected;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void saveVolume()
    {
       VolumeManager.setVolume(slider.value);
        volumeSelected = VolumeManager.getVolume();
    }
    private void Update()
    {
        slider.value = VolumeManager.getVolume();
    }
}
