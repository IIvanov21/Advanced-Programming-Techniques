using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;//Accessed the Unity Events library

public class ChestInteractionArea : MonoBehaviour
{
    public UnityEvent chestInteraction;//Created our custom event

    private void OnTriggerStay(Collider other)//Using trigger collision to check for interaction
    {
        if (other.CompareTag("Player"))//Ensure interaction works only with the player
        {
            if (Input.GetKey(KeyCode.E))
            {
                chestInteraction?.Invoke();//We only want to call the event
            }
        }
    }
}
