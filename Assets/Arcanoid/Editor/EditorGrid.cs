using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorGrid
{
    private const float leftPosition = -4.5f;
    private const float upPosition = 9f;
    private const int columnCount = 10;
    private const int rowCount = 20;
    private const float offsetDown = 0.5f;
    private const float offsetRight = 1f;

    public Vector3 CheckPosition(Vector3 position)
    {
        float tempX = 0;
        float tempY = 0;
        float x = leftPosition - offsetRight / 2;
        float y = upPosition + offsetDown / 2;

        if(position.x > x && position.x < (x + offsetRight * columnCount) &&
            position.y < y && position.y > (y - offsetDown * rowCount))
        {
            for(int i = 0; i < columnCount; i++)
            {
                if(position.x > x && position.x < (x + offsetRight))
                {
                    tempX = x + offsetRight / 2;
                    break;
                }
                else
                {                    
                    x += offsetRight;
                }
            }

            for(int i = 0; i < rowCount; i++)
            {
                if(position.y < y && position.y > (y - offsetDown))
                {
                    tempY = y - offsetDown / 2;
                    break;
                }
                else
                {
                    y-= offsetDown;
                }
            }

        }
        else
        {
            Debug.LogWarning("out of playzone");
        }

        return new Vector3(tempX, tempY);
    }
}
