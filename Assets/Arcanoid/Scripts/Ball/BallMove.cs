using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Rigidbody2D ball;
    private bool isActive;
    private const float Force = 300f;
    private float lastPositionX;

    private void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        ball.bodyType = RigidbodyType2D.Kinematic;
    }

    private void Update()
    {
#if UNITY_ANDROID
        if (Input.touchCount > 0  && !isActive)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.tapCount > 1)
            {
                BallActivate();
            }
        }
#endif

#if UNITY_EDITOR
        if(Input.GetKeyDown(KeyCode.Space) && !isActive)
        {
            BallActivate();
        }
#endif
    }

    private void BallActivate()
    {
        lastPositionX = transform.position.x;
        isActive = true;
        transform.SetParent(null);
        ball.bodyType = RigidbodyType2D.Dynamic;
        ball.AddForce(Vector2.up * Force);
    }

    public void MoveCollision(Collision2D collision)
    {
        float ballPositionX = transform.position.x;

        if (collision.gameObject.TryGetComponent(out PlayerMove player))
        {
            if(ballPositionX < lastPositionX + 0.1 && ballPositionX > lastPositionX - 0.1)
            {
                float collisionPointX = collision.contacts[0].point.x;
                ball.velocity = Vector2.zero;
                float playerCenterPosition = player.gameObject.GetComponent<Transform>().position.x;
                float difference = playerCenterPosition - collisionPointX;
                float direction = collisionPointX < playerCenterPosition ? -1 : 1;
                ball.AddForce(new Vector2(direction * Mathf.Abs(difference * (Force / 2)), Force));
            }
        }

        lastPositionX = ballPositionX;
    }
}