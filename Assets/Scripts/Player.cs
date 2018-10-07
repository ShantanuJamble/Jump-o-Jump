using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    public float speed = 10f;
    Rigidbody2D rb;
    float movemnet = 0f;
    int max_x = 3;
    bool hit_boundary = false;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        movemnet = Controller.getUserInput()*speed;

    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movemnet;
        rb.velocity = velocity;


    }
}
