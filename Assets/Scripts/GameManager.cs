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
        player= new Character();
        UIManager.Instance.MainMenu.SetMainMenuData(player.id, player.level, player.gold);
        UIManager.Instance.Status.SetSatusData(player.baseAtk, player.baseDef, player.baseHealth, player.baseCrit);
    }
}
