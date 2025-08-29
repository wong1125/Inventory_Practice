using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public int atkChangeValue { get; private set; }
    public int defChangeValue { get; private set; }
    public int healthChangeValue { get; private set; }
    public int critChangeValue { get; private set; }
    public string imageKey { get; private set; }

    public Item(string image, int atk = 0, int def = 0, int health = 0, int crit = 0) 
    {
        imageKey = image;
        atkChangeValue = atk;
        defChangeValue = def;
        healthChangeValue = health;
        critChangeValue = crit;
    }
}
