using UnityEngine;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    private void Start()
    {
        if (PlayerPrefs.HasKey("Sounds"))
        {
            LoadSettings();
        }
        else
        {
            SaveSettings();
        }
    }
    private void SaveSettings()
    {

    }
    private void LoadSettings()
    {

    }
    public void Sound()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}