using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    private static int BOUGHT = 0;
    private static int NO_BOUGHT = 1;
    public TextMeshProUGUI price;
    private static int playerPrice;
    public static GameObject lockIcon;
    public Image playerSprite;
    
    void Start()
    {
        playerPrice = int.Parse(price.text);
    }


    public void buy()
    {
        if (int.Parse(ScoreCoin.getMoney()) >= playerPrice)
        {
            isBought(true);
            lockIcon.SetActive(false);
            playerSprite.color = Color.white;
            //TODO: add sound 
        }
        else
        {
            isBought(false);
        }
    }
    private static void isBought(bool confirm)
    {
        if(confirm == true)
        {
            PlayerPrefs.SetInt("Bought", BOUGHT);
        }
        else
        {
            PlayerPrefs.SetInt("Bought", NO_BOUGHT);
        }
    }

}
