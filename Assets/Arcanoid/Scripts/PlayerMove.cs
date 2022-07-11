using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D paddle;
    private SpriteRenderer spriteRenderer;
    private float _moveX = 0f;
    public float speed;
    private const float BorderPositiion = 10.3f;

    private void Awake()
    {
        paddle = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        float positionX = paddle.position.x + _moveX * speed * Time.fixedDeltaTime;
        positionX = Mathf.Clamp(positionX, -BorderPositiion + (spriteRenderer.size.x/2), BorderPositiion - (spriteRenderer.size.x / 2));
        paddle.MovePosition(new Vector2(positionX, paddle.position.y));
    }
    private void OnEnable()
    {
        PlayerInput.OnMove += Move;
    }
    private void OnDisable()
    {
        PlayerInput.OnMove -= Move;
    }
    private void Move(float moveX)
    {
        _moveX = moveX;
    }
}
