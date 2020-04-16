using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TouchControl : MonoBehaviour
{
    public float speed;
    
    //public Animator animator;
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public static bool jump;


    private void Update()
    {
        horizontalMove = TouchControlButton.axisValue * speed;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            SoundManager.playSound("Jump");
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