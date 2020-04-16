using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinText : MonoBehaviour
{
    private TextMeshProUGUI textCoin;

    private void Start()
    {
        textCoin = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textCoin.SetText(ScoreCoin.getMoney());
    }


}
