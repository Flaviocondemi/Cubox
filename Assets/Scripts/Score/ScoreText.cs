using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{

    private TextMeshProUGUI textScore;
    public string level;

    private void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textScore.SetText(Score.getScore("Score" + level));
    }
}
