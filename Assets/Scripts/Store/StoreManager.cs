using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Unity.Collections;

public class StoreManager : MonoBehaviour
{

    /* -----------CONSTS-----------*/

    private const int PLAYER_SELECTED = 1;
    private const int PLAYER_NOT_SELECTED = 0;

    private const int PLAYER_BOUGHT = 1;
    private const int PLAYER_NOT_BOUGHT = 0;

    /* -----------VARIABLES-----------*/

    private int valueSprite;

    public enum PlayerSprite
    {
        player1,
        player2,
        player3,
        player4
    };

    public UnityEvent onPlayerClicked;

    public PlayerSprite pl;

    private static bool bought = false;



    public static void PlayerSelected(PlayerSprite player)
    {
        switch (player)
        {
            case PlayerSprite.player1:
                PlayerPrefs.SetInt("PlayerSprite" + player, PLAYER_SELECTED);
                break;
            case PlayerSprite.player2:
                PlayerPrefs.SetInt("PlayerSprite" + player, PLAYER_SELECTED);
                break;
            case PlayerSprite.player3:
                PlayerPrefs.SetInt("PlayerSprite" + player, PLAYER_SELECTED);
                break;
            case PlayerSprite.player4:
                PlayerPrefs.SetInt("PlayerSprite" + player, PLAYER_SELECTED);
                break;
            default:
                PlayerPrefs.SetInt("PlayerSprite" + "player1", PLAYER_SELECTED);
                break;
        }

    }

    public static void PlayerNotSelected(PlayerSprite player)
    {
        switch (player)
        {
            case PlayerSprite.player1:
                PlayerPrefs.SetInt("PlayerSprite" + player, PLAYER_NOT_SELECTED);
                break;
            case PlayerSprite.player2:                              
                PlayerPrefs.SetInt("PlayerSprite" + player, PLAYER_NOT_SELECTED);
                break;
            case PlayerSprite.player3:                              
                PlayerPrefs.SetInt("PlayerSprite" + player, PLAYER_NOT_SELECTED);
                break;
            case PlayerSprite.player4:                              
                PlayerPrefs.SetInt("PlayerSprite" + player, PLAYER_NOT_SELECTED);
                break;
            default:                                          
                PlayerPrefs.SetInt("PlayerSprite" + "player1", PLAYER_NOT_SELECTED);
                break;
        }

    }

    public static bool isPlayerSelected(PlayerSprite player)
    {
        if (PlayerPrefs.GetInt("PlayerSprite" + player) == PLAYER_SELECTED)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Buy(PlayerSprite player)
    {
        PlayerPrefs.SetInt("PlayerSpriteBuought" + player, PLAYER_BOUGHT);
        bought = true;
    }

    public static bool isBought(PlayerSprite player)
    {
        if(PlayerPrefs.GetInt("PlayerSpriteBuought" + player) == PLAYER_BOUGHT)
            return true;
        else
            return false;
    }
}
