using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//useless
public class PlayerData : MonoBehaviour
{
    
    public MainMenu menu;
    private PlayerData.SavedData playerData = new SavedData();

    private void Start()
    {
        if (PlayerPrefs.HasKey("SaveData"))
        {
            LoadGame();
        }
        else
        {
            SaveGame();
        }
    }
    public class SavedData
    {
        public int energy;        
    }
    private void SaveGame()
    {
        //playerData.energy = menu.energyCount;
        PlayerPrefs.SetString("SaveGame", JsonUtility.ToJson(playerData));
    }
    private void LoadGame()
    {
        playerData = JsonUtility.FromJson<SavedData>(PlayerPrefs.GetString("SaveGame"));
    }
}