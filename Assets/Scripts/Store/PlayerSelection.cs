using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelection : MonoBehaviour
{
    // Start is called before the first frame update

    public Toggle toggle;
    private Image currentSpriteImage;
    public GameObject block;
    public StoreManager.PlayerSprite player;
    private int totalsprite = 4;

    public int costsprite;

    void Start()
    {
        if (StoreManager.isPlayerSelected(player))
        {
            toggle.isOn = true;
            playerSelected();
        }
        else
        {
            toggle.isOn = false;
        }
        
    }

    

    // Update is called once per frame
    public void playerSelected() {

        currentSpriteImage = GameObject.Find(player + "Sprite").GetComponent<Image>();

        if (toggle.isOn)
        {
            if (StoreManager.isBought(player))
            {
                for (int i = 1; i <= totalsprite; i++)
                {
                    Image spriteimages = GameObject.Find("player" + i + "Sprite").GetComponent<Image>();
                    spriteimages.color = Color.gray;
                }

                StoreManager.PlayerSelected(player);
                //block.SetActive(false);
                currentSpriteImage.color = Color.white;
            }
            else
            {
                if (int.Parse(ScoreCoin.getMoney()) > costsprite)
                {
                    StoreManager.Buy(player);
                    block.SetActive(false);
                }
                else
                {
                    //TODO: open alert dialog: you don't have enough money
                    Debug.Log("you don't have enough money");
                    toggle.isOn = false;
                    StoreManager.PlayerNotSelected(player);

                    //Reset the sprite with the first default sprite
                    resetSelection();
                }
            }

        }
        else
        {
            StoreManager.PlayerNotSelected(player);
        }
    }

    private void resetSelection()
    {
        Toggle defaultPlayer = GameObject.Find("Toggleplayer1").GetComponent<Toggle>();
        defaultPlayer.isOn = true;
    }
    
}
