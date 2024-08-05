using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerManager playerManager;

    private Slider healthSlider;

    private void OnEnable()//Game Starts
    {
        playerManager.HealthChanged += UpdateHealthDisplay;
        playerManager.HealthChanged += TestFunction;

    }

    private void OnDisable()
    {
        playerManager.HealthChanged -= UpdateHealthDisplay;
        playerManager.HealthChanged -= TestFunction;

    }

    private void Awake()
    {
        healthSlider = GetComponentInChildren<Slider>();
    }

    private void UpdateHealthDisplay(int newHealth)
    {
        healthSlider.value = newHealth;
    }

    private void TestFunction(int testValue)
    {
        Debug.Log("Test value is:" + testValue);
    }
}
