using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehavior : MonoBehaviour
{
    public string name = "Matt";
    public int age = 33;
    public float mySpeed = 10.2f;
    public int myHealth = 100;
    public int score = 50;
    public bool hasAllKeys = false;
    public int ammoCount = 75;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + name);
        Debug.Log("My age is " + age);
        Debug.Log("My speed is " + mySpeed);
        Debug.Log("My health is " + myHealth);
        Debug.Log("My score is " + score);
        Debug.Log("Does the user have all the key? " + hasAllKeys);
        Debug.Log("Ammo count: " + ammoCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
