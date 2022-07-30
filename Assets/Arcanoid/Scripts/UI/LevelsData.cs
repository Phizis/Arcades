using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsData
{
    private const string KeyName = "Save";
    private LevelsProgress _levelsProgress = new LevelsProgress();

    private void SaveData()
    {
        string saveJson = JsonUtility.ToJson(_levelsProgress);
        PlayerPrefs.SetString(KeyName, saveJson);
        PlayerPrefs.Save();
    }
    public void NewData()
    {
        var levelCount = Resources.LoadAll<GameLevel>("ArcanoidLevels").Length;

        for(int i = 0; i < levelCount; i++)
        {
            _levelsProgress.Levels.Add(new Progress());
        }

        _levelsProgress.Levels[0].isOpened = true;
        SaveData();
        Resources.UnloadUnusedAssets();
    }

    public LevelsProgress GetLevelsProgress()
    {
        if (PlayerPrefs.HasKey(KeyName))
        {
            string saveJson = PlayerPrefs.GetString(KeyName);
            _levelsProgress = JsonUtility.FromJson<LevelsProgress>(saveJson);
        }
        else
        {
            NewData();
        }
        return _levelsProgress;
    }

    public void SaveLevelData(int index, Progress progress)
    {
        _levelsProgress = GetLevelsProgress();

        _levelsProgress.Levels[index] = progress;
        _levelsProgress.Levels[index + 1].isOpened = true;
        SaveData();
    }

    public void Clear()
    {
        PlayerPrefs.DeleteKey(KeyName);
    }
}
