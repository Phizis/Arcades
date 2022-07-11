#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class BlocksGeneration
{
    public void Generate(GameLevel gameLevel, Transform parent)
    {

        for (int i = 0; i < gameLevel.Blocks.Count; i++)
        {
            GameObject game;
#if UNITY_EDITOR
            game = PrefabUtility.InstantiatePrefab(gameLevel.Blocks[i].Block.Prefab, parent) as GameObject;
            if (game.TryGetComponent(out OtherBlocks otherBlock))
            {
                otherBlock.BlocksData = gameLevel.Blocks[i].Block;
            }
#else
            game = GameObject.Instantiate(gameLevel.Blocks[i].Block.Prefab, parent);
#endif
            if (game.TryGetComponent(out Blocks blocks))
            {
                otherBlock.BlocksData = gameLevel.Blocks[i].Block;
                blocks.SetData(gameLevel.Blocks[i].Block as ColoredBlocks);
            }
            game.transform.position = gameLevel.Blocks[i].Position;
        }

    }
}