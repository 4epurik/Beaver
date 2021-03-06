using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private GameObject currentTeleporter;

    void Update()
    {
        if (currentTeleporter != null)
        {
            transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
        }

    }
    
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }

    }
    

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            if (collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }

    }
}


