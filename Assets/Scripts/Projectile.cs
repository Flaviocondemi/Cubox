using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed;
    public GameObject ExplosionEffect;
    public float lifeTime;
    public Rigidbody2D rigidbody;

    private void Start()
    {
        SoundManager.playSound("Fire");
        Invoke("pEffect", lifeTime);
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = transform.right * speed;
    }

    //It will detect explosion effect and it will be destroyed the projectile (gameObject)
    private void pEffect()
    {
        Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    //the projectile must be destroyed when it touches ground, obstacle or enemies

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);

        if (collision.tag == "Enemy")
        {
            Instantiate(ExplosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

        
}
