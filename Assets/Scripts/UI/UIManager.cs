using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get 
        {
            if(_instance == null)
                _instance = new GameObject("UIManager").AddComponent<UIManager>();
            return _instance;
        }
    }

    [field: SerializeField] public UIMainMenu MainMenu { get; private set; }
    [field: SerializeField] public UIStatus Status { get; private set; }
    [field: SerializeField] public UIInventory Inventory { get; private set; }

    private void Awake()
    {
        if(_instance == null)
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

}
