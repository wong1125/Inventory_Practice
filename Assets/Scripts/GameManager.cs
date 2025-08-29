using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            return _instance;
        }
    }

    private Character player;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            if (_instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void Start()
    {

        SetData();
    }

    void SetData()
    {
        List<Item> inventory = new List<Item>() 
        { 
            new Item(atk: 10),
            new Item(def: -5, crit: 10)
        };
        player = new Character("Chad", 20000, 10, 35, 40, 100, 25, inventory);
        UIManager.Instance.MainMenu.SetMainMenuData(player.Id, player.Level, player.Gold);
        UIManager.Instance.Status.SetSatusData(player.BaseAtk, player.BaseDef, player.BaseHealth, player.BaseCrit);
        UIManager.Instance.Inventory.SetInventoryData(inventory);
    }
}
