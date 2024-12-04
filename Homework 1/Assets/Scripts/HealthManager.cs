using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;
    public TMP_Text healthText;
   
    public int health;
    private void Awake()
    {
        instance = this;
    }
    public void DecreaseHealth()
    {
        if (health > 0)
        {
            health--;
        }
      
        if (health <= 0)
        {
            print("You are Dead");
        }
    }
    private void Update()
    {
        healthText.SetText("Health: " + health.ToString());
    }

}
