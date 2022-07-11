using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Blocks : MonoBehaviour
{
    private static int count = 0;
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private int score;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private int life;

#if UNITY_EDITOR
    public BlocksData BlocksData;
#endif
    public void SetData(ColoredBlocks blocksData)
    {
        sprites = new List<Sprite>(blocksData.Sprites);
        score = blocksData.Score;
        spriteRenderer = GetComponent<SpriteRenderer>();
        life = sprites.Count;
        spriteRenderer.sprite = sprites[life - 1];
        MainModule main = GetComponent<ParticleSystem>().main;
        main.startColor = spriteRenderer.color = blocksData.BaseColor;
    }

    public void ApplyDamage()
    {
        life--;
        if(life < 1)
        {
            spriteRenderer.enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            spriteRenderer.sprite = sprites[life - 1];
        }
    }
    private void OnEnable()
    {
        count++;
    }

    private void OnDisable()
    {
        count--;
        if(count < 1)
        {
            Debug.Log("block ended");
        }
    }
}
