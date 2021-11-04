using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    public GameObject Pressurepad;
    public GameObject Box;
    public GameObject Door;

    public Transform doorpos;

    //Vector3 DoorOriginalPosition = Vector3(door.position);

    public bool PadActive = false;


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
        }

        if (PadActive == false) 
        {
            Door.transform.position = new Vector3(doorpos.position.x, 0, doorpos.position.z);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
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
    }
}
