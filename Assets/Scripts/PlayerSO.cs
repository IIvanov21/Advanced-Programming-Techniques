using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerScriptableObject",menuName ="ScriptableObjects/PlayerSO")]
public class PlayerSO : ScriptableObject
{
    public string name;
    public float speed;
    public int health;
    public float jumpValue;
    public float rotationSpeed;
    public GameObject playerObject;
}
