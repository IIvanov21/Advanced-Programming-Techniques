using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //Declare a Delagate 
    public delegate void OnHealthChanged(int newHealth);


    //Define an Event Using the Delegate
    public event OnHealthChanged HealthChanged;

    public int health;

    public int score=0;

    public PlayerSO playerSO;//Data object for the player

    public static PlayerManager instance;//Reference we will be using for the Player Manager

    private void Awake()
    {
        if (instance != null)//Instance is already existing
        {
            Debug.Log("Multiple instance of Player Manager in scene!");//Tell us its existing in the console
            Destroy(gameObject);//Destroy the second instance 
        }
        else
        {
            instance = this;//Assign this to be the singleton
        }

    }

    private void Start()
    {
        health = playerSO.health;
    }
    //The main function which will call the delegate 
    public void TakeDamage(int damage)
    {
        health -= damage;
        HealthChanged?.Invoke(health);//Tip 1: '?' checks if the event is null //Tip 2: Invoke notifies all the subscriber
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            TakeDamage(25);
        }
    }

    
}
