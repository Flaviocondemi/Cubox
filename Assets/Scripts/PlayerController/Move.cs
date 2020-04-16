using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    //public Animator animator;
    public CharacterController2D controller;
    float horizontalMove = 0f;
    bool jump;


    private void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        //animator.SetFloat("speed", Mathf.Abs(horizontalMove));


        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            //animator.SetBool("jump", jump);
        }
        
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }


}