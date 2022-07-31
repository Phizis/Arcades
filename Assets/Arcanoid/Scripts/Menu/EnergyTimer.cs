using System.Collections;
using UnityEngine;
using System;
using TMPro;

public class EnergyTimer : MonoBehaviour
{
    DateTime StartTime;
    DateTime CurrentTime;
    TextMeshProUGUI timerText;
    [SerializeField] GameObject timerObject;
    
    TimeSpan reload = TimeSpan.FromSeconds(360);    

    [SerializeField] private int result = -1;
    TimeSpan difference;

    public float fadeTimer;

    void Start()
    {
        timerText = timerObject.GetComponent<TextMeshProUGUI>();
        fadeTimer = 0f;

        if (PlayerPrefs.HasKey("StartTime"))
        {
            LoadTime();            
        }
        else
        {
            SaveTime();
        }        
    }
    private void FixedUpdate()
    {
        Difference();

        if (MainMenu.energyCount < 100)
        {
            timerText.text = reload.Subtract(difference).ToString(@"mm\:ss");
        }
        else
        {
            timerText.text = "Energy full";
        }        

        result = TimeSpan.Compare(difference, reload);

        if (result >= 0)
        {
            MainMenu.energyCount++;
            StartTime = CurrentTime;
            SaveTime();
        }

        //pop-up
        if (timerObject.activeSelf)
        {
            fadeTimer+= Time.fixedDeltaTime;
            if(fadeTimer >= 5f)
            {
                fadeTimer = 0f;
                timerObject.SetActive(false);
            }
        }
    }
    private void SaveTime()
    {
        PlayerPrefs.SetString("StartTime", DateTime.Now.ToBinary().ToString());
    }
    private void LoadTime()
    {
        long temp = Convert.ToInt64(PlayerPrefs.GetString("StartTime"));
        StartTime = DateTime.FromBinary(temp);

        Difference();

        if (difference > reload)
        {
            MainMenu.energyCount += (int)difference.TotalSeconds / (int)reload.TotalSeconds;
            StartTime = CurrentTime;
            SaveTime();
        }
    }
    private void Difference()
    {
        CurrentTime = DateTime.Now;
        difference = CurrentTime.Subtract(StartTime);
    }
    private void OnApplicationQuit()
    {
        SaveTime();
    }
}