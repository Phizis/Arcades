using UnityEngine;

public class DeadEnd : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<BallMove>(out BallMove ball))
        {
            Destroy(ball.gameObject);
        }
    }
}
