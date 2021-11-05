using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveVer2 : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 300f;
    
    private float moveHori;
    private float moveVert;
    private Vector2 currVelo;

    private bool isJumping = false;
    private bool hasJumped = false;

    public Rigidbody2D PlayerRb;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHori = Input.GetAxis("Horizontal");
        moveVert = Input.GetAxis("Vertical");
        currVelo = PlayerRb.velocity;

        isJumping = false;

        if (Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
            hasJumped = false;            
        }

        if (moveHori != 0)
        {
            PlayerRb.velocity = new Vector2(moveHori * speed, currVelo.y);
        }

        if (isJumping && !hasJumped)
        {
            PlayerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
            //hasJumped = true;
        }
    }
/*
    private void FixedUpdate()
    {
        if (moveHori != 0)
        {
            PlayerRb.velocity = new Vector2(moveHori * speed, currVelo.y);
        }

        if (isJumping && !hasJumped)
        {
            PlayerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
            //hasJumped = true;
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isJumping = false;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isJumping = true;
        }
    }
}
