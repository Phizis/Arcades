using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Loader
{
    private const string Main = "Main";
    private const string Arcanoid = "Arcanoid";
    private const string SpaceShooter = "SpaceShooter";

    public void LoadingMainScene(bool value)
    {
        if (MainMenu.energyCount >= 10)
        {
            MainMenu.energyCount -= 10;
            SaveGame();
            SceneManager.LoadSceneAsync(value ? Main : Arcanoid);
        }
    }

    private void SaveGame()
    {
        PlayerPrefs.SetInt("energy", MainMenu.energyCount);
    }
}
