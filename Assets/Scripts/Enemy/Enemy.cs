using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{

    public int life = 3;
    public Animator animator;
    public float stopDistance;

    private Transform player;
    private Vector2 target;

    private bool isFacingRight = true;

    public GameObject projectile;

    public Transform startPos;
    private float timeBtwShot;
    public float StartTimeBtwShot;

    public TextMeshProUGUI textScore;


    public string level;

    // Start is called before the first frame update

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShot = StartTimeBtwShot;
    }

    private void Update()
    {
        if (player != null)
        {
            target = new Vector2(player.position.x, player.position.y);

            /* FIRST CONDITION
             * this condition flip the enemy according to
             * the distance between the enemy and the player
             */

            if (target.x > transform.position.x && isFacingRight)
            {
                isFacingRight = !isFacingRight;
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            else if (target.x < transform.position.x && !isFacingRight)
            {
                isFacingRight = !isFacingRight;
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }

            /* SECOND CONDITION
             * This condition take the distance between the player
             * and the enemy. Reached a specif "stopDistance" the enemy
             * starts to shoot
             */

            if (Vector2.Distance(transform.position, target) < stopDistance)
            {
                if (timeBtwShot <= 0)
                {
                    Instantiate(projectile, startPos.position, player.rotation);
                    timeBtwShot = StartTimeBtwShot;
                }
                else
                {
                    timeBtwShot -= Time.deltaTime;
                }
            }
        }
        
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

        // Flip collider over the x-axis
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Projectile")
        {
            SoundManager.playSound("Hit");
            Debug.Log("Touched");
            if (life <= 0)
            {
                Score.setScore("Score" + level);
                textScore.SetText(Score.getScore("Score" + level));
                Debug.Log("Death");
                animator.SetBool("hurted", true);
                Destroy(gameObject);
            }
            else
            {
                life -= 1;
                animator.SetBool("hurted", true);
                StartCoroutine(WaitAndExecute());
            }//the life of the zombie decrease by one
            //animator.SetBool("damage", true);
        }
        if (collision.gameObject.name.Equals("feet"))
        {
            Debug.Log("feet die");
            Score.setScore("Score" + level);
            textScore.SetText(Score.getScore("Score" + level));
            SoundManager.playSound("Splat");
            Destroy(gameObject);
        }

    }
    

    //I have used a corountines to switch the state from hurt to idle

    IEnumerator WaitAndExecute()
    {
        yield return new WaitForSeconds(0.8f);
        animator.SetBool("hurted", false);
    }
}