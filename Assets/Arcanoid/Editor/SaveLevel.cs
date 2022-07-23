using System.Collections.Generic;
using UnityEngine;

public class SaveLevel
{
    public List<BlockObject> GetBlocks()
    {
        List<BlockObject> objects = new List<BlockObject>();
        GameObject[] allBlocks = GameObject.FindGameObjectsWithTag("Blocks");

        foreach (var item in allBlocks)
        {
            BlockObject blockObject = new BlockObject();
            blockObject.Position = item.gameObject.transform.position;

            if(item.TryGetComponent(out Blocks blocks))
            {
                blockObject.Block = blocks.BlocksData;
            }

            if(item.TryGetComponent(out OtherBlocks otherBlocks))
            {
                blockObject.Block = otherBlocks.BlocksData;
            }
            objects.Add(blockObject);
        }
        return objects;
    }
}