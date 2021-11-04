using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardPH : MonoBehaviour
{
    
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
            print("Player has been killed");

    }
}
