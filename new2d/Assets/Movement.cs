using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public playerScript controller;
    public Animator animator;
    
    public float runSpeed = 40f;
    
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("jump"))
        {
            jump = true;
        }   
        if (Input.GetButtonDown("Crouch"))
        {
            Crouch = true;
        }
        else if (Input.GetButtonUp("crouch"))
        {
            crouch = flse;
        }
    }

    void FixedUpdate ()
    {

    }
}
