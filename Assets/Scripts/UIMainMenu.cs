using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] GameObject uiSelector;
    [SerializeField] Button statusButton;
    [SerializeField] Button inventoryButton;

    [SerializeField] TextMeshProUGUI idText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] TextMeshProUGUI goldText;


    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
        uiSelector.SetActive(true);
    }

    void OpenStatus()
    {
        uiSelector.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(true);
    }

    void OpenInventory()
    {
        uiSelector.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(true);
    }

    public void SetMainMenuData(string id, int level, int gold)
    {
        idText.text = id;
        levelText.text = $"{level}";
        goldText.text = $"{gold}";
    }
}
