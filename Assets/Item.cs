using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName = "Axe";
    public string itemDesc = "Doubled Edged Axe";
    public int attackStrength = 25;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector(15,15,15) * Time.deltaTime);
    }
}
