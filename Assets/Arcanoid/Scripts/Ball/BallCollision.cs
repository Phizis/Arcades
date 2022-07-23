using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    [SerializeField] private BallMove ball;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ball.MoveCollision(collision);

        if(collision.gameObject.TryGetComponent(out Blocks block))
        {
            block.ApplyDamage();
        }
    }
}
