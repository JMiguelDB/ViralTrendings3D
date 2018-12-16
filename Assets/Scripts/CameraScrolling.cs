using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrolling : MonoBehaviour
{
    public float minPosScrolling = 1f;
    public float maxPosScrolling = 2.8f;
    public float speedScrolling = 1f; 

    void Update()
    {
        float nextPos = Camera.main.orthographicSize;
        nextPos -= Input.mouseScrollDelta.y * speedScrolling * Time.deltaTime;

        if (nextPos < minPosScrolling)
        {
            Camera.main.orthographicSize = minPosScrolling;
        }else if(nextPos > maxPosScrolling)
        {
            Camera.main.orthographicSize = maxPosScrolling;
        }
        else
        {
            Camera.main.orthographicSize = nextPos;
        }
    }
}
