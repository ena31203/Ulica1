using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularWalking : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool backPressed = Input.GetKey("s");

        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        if (leftPressed)
        {
            animator.SetBool("isLeftWalking", true);
        }

        if (!leftPressed)
        {
            animator.SetBool("isLeftWalking", false);
        }

        if (rightPressed)
        {
            animator.SetBool("isRightWalking", true);
        }

        if (!rightPressed)
        {
            animator.SetBool("isRightWalking", false);
        }

        if (backPressed)
        {
            animator.SetBool("isBackWalking", true);
        }

        if (!backPressed)
        {
            animator.SetBool("isBackWalking", false);
        }

    }
}
