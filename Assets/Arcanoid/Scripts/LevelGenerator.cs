using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private readonly LevelIndex _levelIndex = new LevelIndex();
    private readonly BlocksGeneration _blocksGeneration = new BlocksGeneration();
    [SerializeField] private Transform _parentBlocks;
    void Start()
    {
        Init();
    }

    private void Init()
    {
        GameLevel gameLevel = Resources.Load<GameLevel>($"Levels/Level{_levelIndex.GetIndex()}");

        if (gameLevel != null)
        {
            _blocksGeneration.Generate(gameLevel, _parentBlocks);
        }

        LoadingScreen.Screen.Enable(false);
    }

    private void Generate()
    {
        LoadingScreen.Screen.Enable(true);
        Init();
    }
}
