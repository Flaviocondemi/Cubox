using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip hitSound, runSound, jumpSound, 
                            fireSound, coinSound, splatSound,
                            gameoverSound, checkpointSound,
                            powerupSound, clickSound, winSound;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        hitSound = Resources.Load<AudioClip>("Hit");
        jumpSound = Resources.Load<AudioClip>("Jump");
        runSound = Resources.Load<AudioClip>("Run");
        fireSound = Resources.Load<AudioClip>("Fire");
        coinSound = Resources.Load<AudioClip>("Coin");
        splatSound = Resources.Load<AudioClip>("Splat");
        gameoverSound = Resources.Load<AudioClip>("GameOver");
        checkpointSound = Resources.Load<AudioClip>("CheckPoint");
        powerupSound = Resources.Load<AudioClip>("PowerUp");
        clickSound = Resources.Load<AudioClip>("Touch");
        winSound = Resources.Load<AudioClip>("Win");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void playSound(string clip)
    {
        switch (clip)
        {
            case "Fire":
                audioSrc.PlayOneShot(fireSound);
                break;
            case "Hit":
                audioSrc.PlayOneShot(hitSound);
                break;
            case "Run":
                audioSrc.PlayOneShot(runSound);
                break;
            case "Jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "Coin":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "Splat":
                audioSrc.PlayOneShot(splatSound);
                break;
            case "GameOver":
                audioSrc.PlayOneShot(gameoverSound);
                break;
            case "CheckPoint":
                audioSrc.PlayOneShot(checkpointSound);
                break;
            case "PowerUp":
                audioSrc.PlayOneShot(powerupSound);
                break;
            case "Touch":
                audioSrc.PlayOneShot(clickSound);
                break;
            case "Win":
                audioSrc.PlayOneShot(winSound);
                break;

        }

    }


}

