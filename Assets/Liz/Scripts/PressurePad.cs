using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    public GameObject Pressurepad;
    //public GameObject Box;
    public GameObject Door;

    public Transform Padpos;
    public Transform doorpos;

    //Vector3 originalPos;
            
    public bool PadActive = false;

    
    // Start is called before the first frame update
    void Start()
    {
        //doorpos.position.y = OriginalPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (PadActive == true)
        {
            Door.transform.position = new Vector3(doorpos.position.x, transform.position.y + 10, doorpos.position.z);
            //Pressurepad.transform.position = new Vector3(Padpos.position.x, transform.position.y - 0.2f, Padpos.position.z);
        }

        if (PadActive == false) 
        {
            //Door.transform.position = originalPos;
            Door.transform.position = new Vector3(doorpos.position.x, 1, doorpos.position.z);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            PadActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            PadActive = false;
        }
    }

    
}
