using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnInstance;//The object we want to spawn

    [SerializeField]
    [Tooltip("This is the spawn location of the objects.")]
    private Transform spawnTransform;//The location where the object should spawn

    [SerializeField]
    [Range(5,100)]
    private float max;

    public void StartSpawning()
    {
        InvokeRepeating("Spawning", 2.0f, 1.0f);//Execute our spawning function every second, and delay its start by 2 seconds.
    }

    void Spawning()//The function which spawns our objects
    {
        Instantiate(spawnInstance, spawnTransform.position, spawnTransform.rotation);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            Debug.Log("Stop Spawning Objects");
            CancelInvoke("Spawning");//The prompt to stop the repeating of the function
        }
    }
}
