using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "GameData/Create/GameLevel")]
public class GameLevel : ScriptableObject
{
    public List<BlockObject> Blocks = new List<BlockObject>();
}

[System.Serializable]
public class BlockObject
{
    public Vector3 Position;
    public BlocksData Block;
}