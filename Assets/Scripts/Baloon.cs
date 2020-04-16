using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon : MonoBehaviour
{
    private Transform player;
    private Vector2 target;

    public Vector2 offset;

    public float stopDistance;
    public float speed = 10f;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        target = new Vector2(player.position.x, player.position.y);

        if(Vector2.Distance(transform.position, target) < stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target + offset, speed * Time.deltaTime);
        }
        

    }
    
}
