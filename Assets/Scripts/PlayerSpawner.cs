using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public PlayerSO playerScriptableObject;

    // Start is called before the first frame update
    void Start()
    {
        playerScriptableObject.playerObject.name = playerScriptableObject.name;
        Instantiate(playerScriptableObject.playerObject,transform.position,transform.rotation);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }


}
