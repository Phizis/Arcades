using System.Collections.Generic;
using UnityEngine;

public class SaveLevel
{
    public void Save(GameLevel gameLevel)
    {
        gameLevel.Blocks = new List<BlockObject>();
        BaseBlock[] baseBlocks = GameObject.FindObjectsOfType<BaseBlock>();

        foreach (var item in baseBlocks)
        {
            BlockObject blockObject = new BlockObject();
            
            blockObject.Position = item.gameObject.transform.position;
            
            blockObject.Block = item.BlocksData;

            gameLevel.Blocks.Add(blockObject);
        }
    }
}