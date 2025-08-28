using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] Button backButton;

    [SerializeField] TextMeshProUGUI atkText;
    [SerializeField] TextMeshProUGUI defText;
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI critText;

    void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
    }

    public void SetSatusData(int atk, int def, int health, int crit)
    {
        atkText.text = $"{atk}";
        defText.text = $"{def}";
        healthText.text = $"{health}";
        critText.text = $"{crit}";
    }
}
