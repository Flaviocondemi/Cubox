using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemy : MonoBehaviour
{

    public float speed;
    private Vector2 target;
    public  Transform player;
    public GameObject ExplosionEffect;
    public float lifeTime;

    private void Start()
    {
        //Invoke("pEffect", lifeTime);
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}

