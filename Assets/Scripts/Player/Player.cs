using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject destroyEffect;
    public int life;
    public Animator animator;

    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI scoreText;

    public GameObject controlPanelRight;
    public GameObject controlPanelLeft;

    public Transform checkpointPosition;
    public Transform startPosition;

    public string level;


    private void Start()
    {
        Life.setLife(life);
        lifeText.SetText(Life.getLife().ToString());
        if (CheckPoint.isSaved(level) == CheckPoint.STATE_SAVED)
        {
            transform.position = checkpointPosition.position;
        }
        else
        {
            transform.position = startPosition.position;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadZone"))
        {
            if (TouchLayoutManager.getLayout() == 0)
            {
                controlPanelLeft.SetActive(false);
            }
            else
            {
                controlPanelRight.SetActive(false);
            }
            playerDeath();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!Life.isPowerUp())
        {
            if (collision.gameObject.tag == "ProjectileEnemy")
            {
                //SoundManager.playSound("Hit");
                Debug.Log("Touched");
                if (Life.getLife() <= 1)
                {
                    lifeText.SetText(Life.getLife().ToString());
                    Debug.Log("Death");
                    animator.SetBool("hurted", true);
                    if (TouchLayoutManager.getLayout() == 0)
                    {
                        controlPanelLeft.SetActive(false);
                    }
                    else
                    {
                        controlPanelRight.SetActive(false);
                    }

                    playerDeath();
                }
                else
                {
                    life -= 1;
                    Life.setLife(life);
                    lifeText.SetText(life.ToString());
                    animator.SetBool("hurted", true);
                    StartCoroutine(hurtAnimStop());
                }
                //the life of the zombie decrease by one
                //animator.SetBool("damage", true);
            }
        }
    }


    IEnumerator hurtAnimStop()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("hurted", false);
    }


    public void playerDeath()
    {
       
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        gameOverPanel.SetActive(true); //gameover panel shown
        Score.resetScore(level);
        Destroy(gameObject);
        Time.timeScale = 0f;

    }

}
