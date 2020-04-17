using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour
{
    private Image blackFadeImage;
    private GameObject blackFadeObject;
    private Color colorAlpha;

    private static bool isFaded = true;

    private float transparency; //it must be assigned only 1 or 0

    // Start is called before the first frame update
    void Start()
    {
        
        blackFadeImage = gameObject.GetComponent<Image>();
        transparency = 1;
        isFaded = true;
        blackFadeObject = gameObject;
        blackFadeObject.SetActive(true);
        colorAlpha.a = transparency;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFaded)
        {
            Debug.Log(transparency);
            transparency = transparency- Time.deltaTime * 2;
            colorAlpha = blackFadeImage.color;
            colorAlpha.a = transparency;
            blackFadeImage.color = colorAlpha;
        }

        if(transparency <= 0)
        {
            blackFadeObject.SetActive(false);
            isFaded = false;
            transparency = 1;
        }
    }

}
