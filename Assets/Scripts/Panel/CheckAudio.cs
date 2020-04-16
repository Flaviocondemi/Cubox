using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAudio : MonoBehaviour
{
    public Sprite enable;
    public Sprite disable;
    public GameObject audioSource;
    private bool isChecked = false;

    private void Start()
    {
        gameObject.GetComponent<Image>().sprite = enable;
    }
    // Update is called once per frame
    void Update()
    {
        if (isChecked)
        {
            gameObject.GetComponent<Image>().sprite = disable;
            audioSource.SetActive(false);
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = enable;
            audioSource.SetActive(true);
        }
    }
    public void Checking()
    {
        isChecked = !isChecked;
    }
}
