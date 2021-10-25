////////////////////////////////////////////////////////////////////////////////////////////////////////
//File Name: EnemyController
//Author: Fnu Yiliqi
//Student Number: 101289355
//Last Modified On : 10/24/2021
//Description : Class for enemy movement and checking bounds
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;
    
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    
    private void _Move()
    {
        transform.position += new Vector3(0.0f,verticalSpeed * direction * Time.deltaTime, 0.0f);
    }
    
    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
