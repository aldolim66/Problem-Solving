using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public KeyCode up = KeyCode.W;
    public KeyCode bottom = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;

    public float speed = 8.0f;
    public float yBoundary = 8.0f;

    private Rigidbody2D Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 velocity = Rb.velocity;

        // tekan W
        if(Input.GetKey(up))
        {
            velocity.y = speed;
        }
        // tekan A
        else if (Input.GetKey(left))
        {
            velocity.x = -speed;
        }
        // tekan S
        else if (Input.GetKey(bottom))
        {
            velocity.y = -speed;
        }
        // tekan D
        else if (Input.GetKey(right))
        {
            velocity.x = speed;
        }
        else
        {
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }

        Rb.velocity = velocity;
        Vector3 position = transform.position;
        if(position.y > yBoundary)
        {
            position.y = yBoundary;
        }
        else if(position.y < -yBoundary)
        {
            position.y = -yBoundary;
        }
        transform.position = position;

    }
}
