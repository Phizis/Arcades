using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Rigidbody2D ball;
    private bool isActive;
    private const float Force = 200f;

    private void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        ball.bodyType = RigidbodyType2D.Kinematic;
    }

    private void OnEnable()
    {
        PlayerInput.OnClicked += BallActivate;
    }
    private void OnDisable()
    {
        PlayerInput.OnClicked -= BallActivate;        
    }

    private void BallActivate()
    {
        if (!isActive)
        {
            isActive = true;
            transform.SetParent(null);
            ball.bodyType = RigidbodyType2D.Dynamic;
            AddForce();
        }
    }
    public void AddForce(float direction = 0f)
    {
        ball.velocity = Vector2.zero;
        ball.AddForce(new Vector2(direction * (Force / 2), Force));
    }
}