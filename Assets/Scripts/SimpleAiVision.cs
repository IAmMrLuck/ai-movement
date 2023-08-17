using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleAiVision : MonoBehaviour
{

    // this handles seeing the player character

    public GameObject playerCharacter;
    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerCharacter = collision.gameObject;
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerCharacter = null;
        }
    }

}
