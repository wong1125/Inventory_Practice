using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    int atkChangeValue;
    int defChangeValue;
    int healthChangeValue;
    int critChangeValue;


    public Item(int atk = 0, int def = 0, int health = 0, int crit = 0) 
    {
        atkChangeValue = atk;
        defChangeValue = def;
        healthChangeValue = health;
        critChangeValue = crit;
    }
}
