using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    public static LoadingScreen Screen = null;
    [SerializeField] Canvas canvas;

    private void Awake()
    {
        if(Screen == null)
        {
            Screen = this;
            DontDestroyOnLoad(gameObject);
            canvas.enabled = false;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Enable(bool value)
    {
        if (value)
        {
            canvas.enabled = value;
        }
        else
        {
            Invoke(nameof(Disable), 0.5f);
        }
    }

    private void Disable()
    {
        canvas.enabled = false;
    }
}
