using UnityEngine;

public class DeadEnd : MonoBehaviour
{
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject gameOverMenu;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<BallMove>(out BallMove ball))
        {
            pauseButton.SetActive(false);
            gameOverMenu.SetActive(true);
            Destroy(ball.gameObject);
        }
    }
}
