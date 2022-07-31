using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MainMenu : MonoBehaviour
{  
    [SerializeField] private TextMeshProUGUI energyText;    
    public static int energyCount;
    private void Start()
    {
        if (PlayerPrefs.HasKey("energy"))
        {
            LoadGame();
        }
        else
        {
            energyCount = 100;
            SaveGame();
        }
        //energyCount = 80;
    }
    private void FixedUpdate()
    {
        if (energyCount > 100)
        {
            energyCount = 100;
        }

        energyText.text = energyCount + "/100";
    }
    private void SaveGame()
    {
        PlayerPrefs.SetInt("energy", energyCount);
    }    
    private void LoadGame()
    {
        energyCount = PlayerPrefs.GetInt("energy");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("energy", energyCount);
    }
}