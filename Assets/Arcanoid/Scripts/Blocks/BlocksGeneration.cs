#if UNITY_EDITOR
using UnityEngine;

#endif
using UnityEditor;

public class BlocksGeneration
{
    public void Generate(GameLevel gameLevel, Transform parent)
    {

        for (int i = 0; i < gameLevel.Blocks.Count; i++)
        {
            GameObject game;
#if UNITY_EDITOR
            game = PrefabUtility.InstantiatePrefab(gameLevel.Blocks[i].Block.Prefab, parent) as GameObject;
            if (game.TryGetComponent(out BaseBlock baseBlock))
            {
                baseBlock.BlocksData = gameLevel.Blocks[i].Block;
            }
#else
            game = GameObject.Instantiate(gameLevel.Blocks[i].Block.Prefab, parent);
#endif
            if (game.TryGetComponent(out Blocks blocks))
            {
                blocks.SetData(gameLevel.Blocks[i].Block as ColoredBlocks);
            }
            game.transform.position = gameLevel.Blocks[i].Position;
        }

    }
}