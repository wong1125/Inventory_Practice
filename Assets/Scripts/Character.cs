using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Id { get; private set; }
    public int Gold { get; private set; }
    public int Level { get; private set; }
    public int BaseAtk { get; private set; } 
    public int BaseDef { get; private set; } 
    public int BaseHealth { get; private set; }
    public int BaseCrit { get; private set; }
    public List<Item> Inventory { get; private set; }

    public Character(string id, int gold, int level, int baseAtk, int baseDef, int baseHealth, int baseCrit, List<Item> inventory)
    {
        Id = id;
        Gold = gold;
        Level = level;
        BaseAtk = baseAtk;
        BaseDef = baseDef;
        BaseHealth = baseHealth;
        BaseCrit = baseCrit;
        Inventory = inventory;
    }

    void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    void Equip(Item item)
    {

    }

    void UnEqip(Item item)
    {

    }
}
