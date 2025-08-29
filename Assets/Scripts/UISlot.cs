using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    private bool isEquipped;
    [SerializeField] Button equipToggle;
    [SerializeField] Image equipIndicator;
    public Item Item {  get; private set; }
    
    public void SetItem(Item itemAdded)
    {
        Item = itemAdded;
    }

    void RefreshAI()
    {

    }

}
