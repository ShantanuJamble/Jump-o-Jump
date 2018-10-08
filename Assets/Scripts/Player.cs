using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    public float speed = 10f;
    Rigidbody2D rb;
    float movemnet = 0f;
    int max_x = 3;
    bool hit_boundary = false;
    int score = 0;
    public Text score_text;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Coin"))
        {
            score += 1;
            collision.collider.gameObject.SetActive(false);
            score_text.text = score.ToString();
        }
    }
}
