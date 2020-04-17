using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUp : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public  Animator anim;
    public float targetTime;
    public GameObject countDown;


    private void Update()
    {
        if (Life.isPowerUp())
        {
            targetTime -= Time.deltaTime;
            countText.SetText(targetTime.ToString("0.00"));
            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }
        else
        {
            anim.SetBool("Powerup", false);
        }
    }

    void timerEnded()
    {
        Life.setPowerUp(false);
        countDown.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PowerUp")) {
            countDown.SetActive(true);
            SoundManager.playSound("PowerUp");
            Destroy(collision.gameObject);
            anim.SetBool("Powerup", true);
            Life.setPowerUp(true);
        }
    }
}
