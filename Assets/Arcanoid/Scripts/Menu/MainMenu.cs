using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MainMenu : MonoBehaviour
{  
    [SerializeField] private TextMeshProUGUI energyText;    
    public static int energyCount = 0;

    private void Start()
    {        
        if (PlayerPrefs.HasKey("energy"))
        {
            LoadGame();
        }
        else
        {
            SaveGame();
        }
        //energyCount = 80;
    }
    private void FixedUpdate()
    {
        if(energyCount > 100)
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

    public void Loading()
    {
        if (energyCount >= 10)
        {
            energyCount -= 10;
            SaveGame();
            SceneManager.LoadScene(1);
        }
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("energy", energyCount);
    }
}