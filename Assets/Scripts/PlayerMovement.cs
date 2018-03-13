using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;

    Rigidbody2D rb;

    Animator anim;
    Vector2 movement;
    bool playerMoving;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        playerMoving = false;

        if (Input.GetAxis("Horizontal") > 0.5f || Input.GetAxis("Horizontal") < -0.5f)
        {
            movement = new Vector2(Input.GetAxis("Horizontal"),0f);
            rb.AddForce(movement * movementSpeed);
            playerMoving = true;
        }

        if (Input.GetAxis("Vertical") >0.5f || Input.GetAxis("Vertical") < -0.5f)
        {
            movement = new Vector2(0f, Input.GetAxis("Vertical"));
            rb.AddForce(movement * movementSpeed);
            playerMoving = true;
        }

        anim.SetFloat("MoveX", Input.GetAxis("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxis("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", movement.x);
        anim.SetFloat("LastMoveY", movement.y);
    }
}
