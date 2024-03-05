using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Animator animator;
    float velocity = 0.0f;
    public float acceleration = 0.1f;
    public float deceleration = 0.5f;
    int VelocityHash;

    void Start()
    {
        animator = GetComponent<Animator>();
        VelocityHash = Animator.StringToHash("Velocity");
    }
    
    void Update()
    {
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey("left shift");

        if (forwardPressed && velocity < 1.0f)
        {
            velocity += Time.deltaTime * acceleration;
            Debug.Log("Forward Pressed: " + forwardPressed);
        }
        
        if(!forwardPressed && velocity > 0.0f)
        {
            velocity -= Time.deltaTime * deceleration;
        }

        if(!forwardPressed && velocity < 0.0f)
        {
            velocity = 0.0f;
        }

        animator.SetFloat(VelocityHash, velocity);
    }
}
