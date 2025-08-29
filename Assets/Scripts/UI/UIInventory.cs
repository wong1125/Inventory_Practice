using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] Button backButton;

    [SerializeField] UISlot uiSlotPrefab;

    [SerializeField] Transform slotParent;
    [SerializeField] int initialSlotSize;
    private List<UISlot> slots = new List<UISlot>();


    void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
        InitInventoryUI();
    }

    void InitInventoryUI()
    {
        for (int i = 0; i < initialSlotSize; i++)
        {
            UISlot slot = Instantiate(uiSlotPrefab, slotParent);
            slots.Add(slot);
        }
    }

    public void SetInventoryData(List<Item> items)
    {
        //아이템 수가 기본 인벤토리보다 많으면, 인벤토리 확장
        if (slots.Count < items.Count)
        {
            int newSlotNum = items.Count - slots.Count;
            for (int i = 0; i < newSlotNum; i++)
            {
                UISlot slot = Instantiate(uiSlotPrefab, slotParent);
                slots.Add(slot);
            }
        }
        
        for (int i = 0; i < items.Count; i++)
        {
            slots[i].RefreshUI(items[i]);
        }
    }
}
