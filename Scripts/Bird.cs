using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public MusicManager music;
    Rigidbody2D rb;
    Vector2 direction;
    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
        TouchJump();

        Down();
    }

    public void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = 0;
            rb.drag = 2;

            direction = Vector2.up;
            rb.AddForce(direction * speed, ForceMode2D.Impulse);

                        music.Flap();
        }
    }

    public void TouchJump()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
            rb.gravityScale = 0;
            rb.drag = 2;

            direction = Vector2.up;
            rb.AddForce(direction * speed, ForceMode2D.Impulse);

                        music.Flap();                
            }
        }
    }

    public void Down()
    {
              rb.gravityScale = 1;
              rb.drag = 0;
    }
}
