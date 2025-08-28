using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string id { get; private set; }
    public int gold { get; private set; }
    public int level { get; private set; }
    public int baseAtk { get; private set; } 
    public int baseDef { get; private set; } 
    public int baseHealth { get; private set; }
    public int baseCrit { get; private set; }

    public Character()
    {
        id = "Chad";
        gold = 20000;
        level = 10;
        baseAtk = 35;
        baseDef = 40;
        baseHealth = 100;
        baseCrit = 25;
    }
}
