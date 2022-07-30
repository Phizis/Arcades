using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using TMPro;

public class ShopMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI batteryText;
    [SerializeField] TextMeshProUGUI addEnergyText;
    int batteries;

    private void Start()
    {
        if (PlayerPrefs.HasKey("batteries"))
        {
            batteries = PlayerPrefs.GetInt("batteries");
        }
        else
        {
            PlayerPrefs.SetInt("batteries", 0);
        }

        UpdateBatteries();
    }

    public void UpdateBatteries()
    {
        PlayerPrefs.SetInt("batteries", batteries);
        batteryText.text = batteries.ToString();
    }

    public void OnPurchasingCompleted(Product product)
    {
        switch (product.definition.id)
        {
            case "one_battery":
                AddBattery();
                break;

            case "five_batteries":
                AddBatteries();
                break ;
        }
    }

    public void AddBattery()
    {
        batteries++;
        Debug.Log("Purchase: get 1 battery");

        UpdateBatteries();
    }

    public void AddBatteries()
    {
        batteries+=5;
        Debug.Log("Purchase: get 5 battery");

        UpdateBatteries();
    }

    public void SpendBattery()
    {
        if (batteries > 0)
        {
            batteries--;
            UpdateBatteries();
            MainMenu.energyCount = 100;
        }
        else
        {
            addEnergyText.text = "You have not enough batteries!";
        }
    }
}
