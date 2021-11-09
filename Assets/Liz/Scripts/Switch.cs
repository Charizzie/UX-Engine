using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool SwitchActive = false;

    public GameObject Door;
    public Transform doorpos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && SwitchActive == true)
        {
            Door.transform.position = new Vector3(doorpos.position.x, transform.position.y + 10, doorpos.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SwitchActive = true;
        }
    }
}
