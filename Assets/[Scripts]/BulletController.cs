////////////////////////////////////////////////////////////////////////////////////////////////////////
//File Name: Background Controller
//Author: Fnu Yiliqi
//Student Number: 101289355
//Last Modified On : 10/24/2021
//Description : Class for handling bullet movement
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    private BulletManager bulletManager;
    public int damage;
    
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }
    
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    
    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }
    
    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
