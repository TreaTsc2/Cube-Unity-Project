using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

     int CHP;
     public int MHP = 1000;

    // Start is called before the first frame update
    void Start()
    {
        CHP = MHP;  
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("r")) 
            takeDamage(1000);
    }

   internal void takeDamage(int damage)
    {
        CHP -= damage;
        print("Ouch that hurt! my health is now " + CHP);
    }

    internal int whatsYourMaxHealth()
    {
        return MHP;
    }
}
