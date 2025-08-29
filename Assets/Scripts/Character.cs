using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Id { get; private set; }
    public int Gold { get; private set; }
    public int Level { get; private set; }
    public int Attack { get; private set; } 
    public int Defend { get; private set; } 
    public int Health { get; private set; }
    public int Critical { get; private set; }
    public List<Item> Inventory { get; private set; }

    public Character(string id, int gold, int level, int baseAtk, int baseDef, int baseHealth, int baseCrit, List<Item> inventory)
    {
        Id = id;
        Gold = gold;
        Level = level;
        Attack = baseAtk;
        Defend = baseDef;
        Health = baseHealth;
        Critical = baseCrit;
        Inventory = inventory;
    }

    void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void Equip(Item item)
    {
        Attack += item.atkChangeValue;
        Defend += item.defChangeValue;
        Health += item.healthChangeValue;
        Critical += item.critChangeValue;
    }

    public void UnEquip(Item item)
    {
        Attack -= item.atkChangeValue;
        Defend -= item.defChangeValue;
        Health -= item.healthChangeValue;
        Critical -= item.critChangeValue;
    }
}
