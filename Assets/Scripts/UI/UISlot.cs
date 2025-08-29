using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    private bool isEquipped;
    [SerializeField] Image itemImage;
    [SerializeField] Button equipToggle;
    [SerializeField] GameObject equipIndicator;
    public Item Item {  get; private set; }

    private Character player;

    private void Start()
    {
        player = GameManager.Instance.Player;
        equipIndicator.SetActive(false);
        equipToggle.onClick.AddListener(SetItem);
    }

    //UI에 아이템 정보 넣기
    public void RefreshUI(Item itemAdded)
    {
        Item = itemAdded;
        itemImage.sprite = Resources.Load<Sprite>(Item.imageKey);
    }

    //아이템 장착 or 빼기
    void SetItem()
    {
        if (!isEquipped)
        {
            equipIndicator.SetActive(true);
            player.Equip(Item);
            UIManager.Instance.Status.SetSatusData(player.Attack, player.Defend, player.Health, player.Critical);
        }
        else
        {
            equipIndicator.SetActive(false);
            GameManager.Instance.Player.UnEquip(Item);
            UIManager.Instance.Status.SetSatusData(player.Attack, player.Defend, player.Health, player.Critical);
        }
        isEquipped = !isEquipped;
    }

}
