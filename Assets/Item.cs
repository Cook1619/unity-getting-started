using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName = "Axe";
    public string itemDesc = "Doubled Edged Axe";
    public Sprite itemIcon;
    public int attackStrength = 25;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name: " + itemName);
        Debug.Log("Description: " + itemDesc);
        Debug.Log("Attack Strength: " + attackStrength);
    }
}
