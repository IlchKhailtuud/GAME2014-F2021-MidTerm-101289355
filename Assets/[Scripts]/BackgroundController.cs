////////////////////////////////////////////////////////////////////////////////////////////////////////
//File Name: Background Controller
//Author: Fnu Yiliqi
//Student Number: 101289355
//Last Modified On : 10/24/2021
//Description : Class for handling scrolling background
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    void Update()
    {
        _Move();
        _CheckBounds();
    }

  
    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }
    
    
    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    //check if the image has moved out of the screen then reset
    private void _CheckBounds()
    {
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
