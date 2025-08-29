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
    public Character Player { get { return player; } }

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

    //생성자로 데이터 넣어주기
    public void SetData()
    {
        List<Item> inventory = new List<Item>() 
        { 
            new Item("Sword", atk: 10),
            new Item("Shield", def: 10, crit: -5)
        };
        player = new Character("Chad", 20000, 10, 35, 40, 100, 25, inventory);
        UIManager.Instance.MainMenu.SetMainMenuData(player.Id, player.Level, player.Gold);
        UIManager.Instance.Status.SetSatusData(player.Attack, player.Defend, player.Health, player.Critical);
        UIManager.Instance.Inventory.SetInventoryData(inventory);
    }
}
