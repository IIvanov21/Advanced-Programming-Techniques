using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;//Reference to the events library

public class InteractionArea : MonoBehaviour
{
    bool interacted=false;
    public UnityEvent interactionEvent;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(!interacted)
            {
                interactionEvent?.Invoke();
                interacted=true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))interacted=false;    
    }
}
