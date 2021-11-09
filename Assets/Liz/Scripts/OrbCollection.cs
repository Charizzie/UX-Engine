using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCollection : MonoBehaviour
{
    //public bool hold = false;
    public bool pass = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && pass == true)
        {
            Destroy(gameObject);
            Debug.Log("hold");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           pass = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pass = false;
    }
}
