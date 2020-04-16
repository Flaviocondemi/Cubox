using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Chronometer : MonoBehaviour
{
    private TextMeshProUGUI chronometerText;
    private  float targetTime;
    // Start is called before the first frame update
    void Start()
    {
        chronometerText = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        targetTime += Time.deltaTime;
        chronometerText.SetText(targetTime.ToString("0.00"));
    }
}
