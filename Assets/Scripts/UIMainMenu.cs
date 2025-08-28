using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] GameObject uiSelector;
    [SerializeField] Button statusButton;
    [SerializeField] Button inventoryButton;


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
}
