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
        SceneManager.LoadSceneAsync(value ? Main : Arcanoid);
    }
}
