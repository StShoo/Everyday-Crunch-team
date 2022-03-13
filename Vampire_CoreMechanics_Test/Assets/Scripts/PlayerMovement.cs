using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 4f;
    private Vector2 moveVector;
    private Rigidbody2D rb;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVector = moveInput * movementSpeed;

        if (Input.GetAxis("Horizontal")!=0 && Input.GetAxis("Vertical")!=0)
        {
            for (int i = 0; i < 2; i++)
            {
                moveVector[i] = moveVector[i] - 1f;
            }
        }
        
        // Debug.Log(moveVector);
        
        rb.MovePosition(rb.position + moveVector * Time.deltaTime);
    }
    
}
