using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BarnDoorsInteractionArea : MonoBehaviour
{
    public UnityEvent barnDoorInteraction;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                barnDoorInteraction?.Invoke();
            }
        }
    }
}
