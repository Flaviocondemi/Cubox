using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public Transform player;
    private float speed = 5f;

    public float stopDistance;

    private Vector2 target;

    public GameObject projectile;

    public Transform startPos;
    private float timeBtwShot;
    public float StartTimeBtwShot;


    // Update is called once per frame
    void Update()
    {
         Vector2 direction = player.position - transform.position;
         float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
         Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
         transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, player.position) < stopDistance)
        {
            if (timeBtwShot <= 0)
            {
                Instantiate(projectile, startPos.position, rotation);
                timeBtwShot = StartTimeBtwShot;
            }
            else
            {
                timeBtwShot -= Time.deltaTime;
            }
        }
    }
}
