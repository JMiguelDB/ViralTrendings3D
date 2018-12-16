using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float speedMovement = 1f;
    public int boundary = 10;

    int screenWidth;
    int screenHeight;
    float axisX;
    float axisY;
    // Start is called before the first frame update
    void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        axisX = 0;
        axisY = 0;
        //Vector3 screenPoint = Input.mousePosition.normalized;
        //screenPoint.z = 10.0f; //distance of the plane from the camera
        //transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
        //print(screenPoint);
        //transform.position += screenPoint * slowRateMovement;
        if (Input.mousePosition.x > screenWidth - boundary)
        {
            axisX += speedMovement * Time.deltaTime; // move on +X axis
        }
        if (Input.mousePosition.x < 0 + boundary)
        {
            axisX -= speedMovement * Time.deltaTime; // move on -X axis
        }
        if (Input.mousePosition.y > screenHeight - boundary)
        {
            axisY += speedMovement * Time.deltaTime; // move on +Z axis
        }
        if (Input.mousePosition.y < 0 + boundary)
        {
            axisY -= speedMovement * Time.deltaTime; // move on -Z axis
        }
        transform.position += new Vector3(axisX, axisY,0);
    }
}
