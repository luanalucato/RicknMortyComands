﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgraundScroller : MonoBehaviour
{
    public BoxCollider2D collider;
    
    public Rigidbody2D rb;
     
    private float width;

    private float scrollSpeed = -2f;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent <BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, 0);
        resetObstacle();
    }

    // Update is called once per frame
    void Update()
    
    {
        if (transform.position.x < -width)
       {
         Vector2 restPosition = new Vector2(width * 2f, 0);
         transform.position = (Vector2)transform.position + restPosition;
         resetObstacle();
         
        
       }

    }
}

void resetObstacle()
{
    transform.getChild(0).localPosition = new Vector3(0, rambom.range(-3,3), 0);
}
