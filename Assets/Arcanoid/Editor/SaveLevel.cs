using System.Collections.Generic;
using UnityEngine;

    public class SaveLevel
    {
        public void Save(GameLevel gameLevel)
        {
            gameLevel.Blocks = new List<BlockObject>();
            Blocks[] baseBlocks = GameObject.FindObjectsOfType<Blocks>();

            foreach (var item in baseBlocks)
            {
                BlockObject blockObject = new BlockObject
                {
                    Position = item.gameObject.transform.position,

                    Block = item.BlocksData
                };

                gameLevel.Blocks.Add(blockObject);
            }
        }
    }