using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;//Reference to the events library

public class InteractionArea : MonoBehaviour
{
    bool interacted=false;
    public UnityEvent interactionEvent;
    public UnityEvent stayInteraction;


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


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                stayInteraction?.Invoke();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))interacted=false;    
    }
}
