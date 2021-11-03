using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public GameObject player;
    

    //private bool hasMoved = false;
    private bool triggerEntered = false;

    public float speed = 3;
    public bool isFloating = false;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && triggerEntered == true)
        {
            //moveobject
            Vector3 move = new Vector3(+1, 0, 0);
            gameObject.transform.position += move * Time.deltaTime * speed;            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerEntered = true;        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        triggerEntered = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isFloating = false;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            isFloating = true;
        }
    }
}
