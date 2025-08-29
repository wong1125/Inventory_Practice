using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    private bool isEquipped;
    [SerializeField] Image itemImage;
    [SerializeField] Button equipToggle;
    [SerializeField] Image equipIndicator;
    public Item Item {  get; private set; }
    
    public void SetItem(Item itemAdded)
    {
        Item = itemAdded;
        RefreshAI();
    }

    void RefreshAI()
    {
        itemImage.sprite = Resources.Load<Sprite>(Item.imageKey);
    }

}
