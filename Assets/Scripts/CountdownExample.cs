using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownExample : MonoBehaviour
{
    public bool waitCheck = false;
    
    [SerializeField]
    private float waitSeconds = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Waiter());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            waitCheck = true;
        }
    }

    IEnumerator Waiter()
    {
        while (!waitCheck)
        {
            //This is the area where you can perform actions before the condition is met
            Debug.Log("Waiting");
            yield return new WaitForSeconds(waitSeconds);
        }

        Debug.Log("Completed Waiting!");
        //This is the area where you can perform actions after the condition is met
    }
}
