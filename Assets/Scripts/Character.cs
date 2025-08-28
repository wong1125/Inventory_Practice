using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] string id = "Chad";
    [SerializeField] int gold = 20000;
    [SerializeField] int level = 10;

    [SerializeField] int baseAtk = 35;
    [SerializeField] int baseDef = 40;
    [SerializeField] int baseHealth = 100;
    [SerializeField] int baseCrit = 25;
}
