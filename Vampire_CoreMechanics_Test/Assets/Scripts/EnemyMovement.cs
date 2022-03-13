using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    private Vector2 moveVector;
    private Rigidbody2D rb;
    private GameObject target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    
    void FixedUpdate()
    {
        
        transform.position = Vector2.MoveTowards(transform.position,
            target.transform.position, movementSpeed*Time.deltaTime);
    }
}
