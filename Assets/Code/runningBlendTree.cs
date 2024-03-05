using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runningBlendTree : MonoBehaviour
{
    Animator animator;
    float velocityX = 0.0f;
    float velocityY = 0.0f;
    public float acceleration = 2.0f;
    public float deceleration = 4.0f;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool backPressed = Input.GetKey("s");


        //FORWARD
        if (forwardPressed)
        {
            velocityY += Time.deltaTime * acceleration;     //w pritisnut -> ubrzaj
        }

        if (!forwardPressed && velocityY > 0.0f)
        {
            velocityY -= Time.deltaTime * deceleration;     //w nije vise pritisnut, a naprijed smo -> uspori prema nazad
        }

        //FORWARD RESET
        //if (!forwardPressed && velocityY < 0.0f)            // reset
        //{                                                   // ?????? nez jel triba ovo
        //    velocityY = 0.0f;                               //w nije pritisnut a deceleration je otiao u - 
        //}

        //BACK
        if (backPressed)
        {
            velocityY -= Time.deltaTime * acceleration;
        }

        if(!backPressed && velocityY < 0.0f)
        {
            velocityY += Time.deltaTime * deceleration;
        }


        //LEFT
        if (leftPressed)
        {
            velocityX -= Time.deltaTime * acceleration;
        }

        if (!leftPressed && velocityX < 0.0f)
        {
            velocityX += Time.deltaTime * deceleration;     //a nije vise pritisnut,a lijevo smo -> uspori prema desno
        }


        //RIGHT
        if (rightPressed)
        {
            velocityX += Time.deltaTime * acceleration;
        }

        if (!rightPressed && velocityX > 0.0f)
        {
            velocityX -= Time.deltaTime * deceleration;     //d nije vise pritisnut, a desno smo -> uspori prema lijevo
        }


        //LEFT/RIGHT RESET
        if (!leftPressed && !rightPressed && velocityX != 0.0f && (velocityX > -0.5f && velocityX < 0.5f))
        {
            velocityX = 0.0f;
        }

        //!!!!!!!!
        animator.SetFloat("velocityX", velocityX);
        animator.SetFloat("velocityY", velocityY);
    }
}
