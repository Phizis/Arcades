using UnityEngine;
using System;

public class PlayerInput : MonoBehaviour
{
    public static event Action<float> OnMove;

    private Vector2 startPosition = Vector2.zero;
    private float direction = 0f;
    private void Update()
    {
#if UNITY_EDITOR
        OnMove?.Invoke(Input.GetAxisRaw("Horizontal"));
#endif
#if UNITY_ANDROID
        GetTouchInput();
#endif
    }

    private void GetTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                //case TouchPhase.Began:
                //    startPosition = touch.position;
                //    direction = 0f;
                //    break;
                case TouchPhase.Moved:
                    direction = touch.position.x > startPosition.x ? 1f : -1f;
                    break;
                //case TouchPhase.Stationary:
                //    break;
                //case TouchPhase.Ended:
                //    break;
                //case TouchPhase.Canceled:
                //    break;
                default:
                    startPosition = touch.position;
                    direction = 0f;
                    break;

            }
            OnMove?.Invoke(direction);
        }
    }
}