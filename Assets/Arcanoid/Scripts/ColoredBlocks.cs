using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColoredBlock", menuName = "GameData/Create/ColoredBlock")]
public class ColoredBlocks : BlocksData
{
    public List<Sprite> Sprites;
    public Color BaseColor;
    public int Score;
}
