using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    [SerializeField] private BallMove ball;
    private float lastPositionX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float ballPositionX = transform.position.x;

        if (collision.gameObject.TryGetComponent(out PlayerMove playerMove))
        {
            if (ballPositionX < lastPositionX + 0.1 && ballPositionX > lastPositionX - 0.1)
            {
                float collisionPointX = collision.contacts[0].point.x;
                float playerCenterPosition = playerMove.gameObject.transform.position.x;
                float difference = playerCenterPosition - collisionPointX;
                float direction = collisionPointX < playerCenterPosition ? -1 : 1;
                ball.AddForce(direction * Mathf.Abs(difference));
            }
        }

        lastPositionX = ballPositionX;

        if (collision.gameObject.TryGetComponent(out IDamageable damageable))
        {
            damageable.ApplyDamage();
        }
    }
}
