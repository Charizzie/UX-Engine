using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    public GameObject Pressurepad;
<<<<<<< HEAD
    public GameObject Box;
    public GameObject Door;

    public Transform doorpos;

    //Vector3 DoorOriginalPosition = Vector3(door.position);

    public bool PadActive = false;


=======
    //public GameObject Box;
    public GameObject Door;

    public Transform Padpos;
    public Transform doorpos;
            
    public bool PadActive = false;

    
>>>>>>> main
    // Start is called before the first frame update
    void Start()
    {
        //DoorOriginalPos = Door.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (PadActive == true)
        {
            Door.transform.position = new Vector3(doorpos.position.x, transform.position.y + 10, doorpos.position.z);
<<<<<<< HEAD
=======
            //Pressurepad.transform.position = new Vector3(Padpos.position.x, transform.position.y - 0.2f, Padpos.position.z);
>>>>>>> main
        }

        if (PadActive == false) 
        {
            Door.transform.position = new Vector3(doorpos.position.x, 0, doorpos.position.z);
<<<<<<< HEAD
=======
            //Pressurepad.transform.position = new Vector3(Padpos.position.x, transform.position.y, Padpos.position.z);
>>>>>>> main
        }
        
    }

<<<<<<< HEAD
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Box")
=======
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
>>>>>>> main
        {
            PadActive = true;
        }
    }

<<<<<<< HEAD
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Box")
=======
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
>>>>>>> main
        {
            PadActive = false;
        }
    }
<<<<<<< HEAD
=======

    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         if (collision.collider.tag == "Box")
         {            
             PadActive = true;
         }
     }

     private void OnCollisionExit2D(Collision2D collision)
     {
         if (collision.collider.tag == "Box")
         {
             PadActive = false;            
         }
     }*/
>>>>>>> main
}
