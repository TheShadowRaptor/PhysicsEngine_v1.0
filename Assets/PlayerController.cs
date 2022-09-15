using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //(PRETEND) WE ARE NOT IN UNITY
    public float acceleration = 1.0f; // units/second/second
    private Vector2 position; // player position
    private Vector2 velocity; // player velocity (speed + direction)

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position; // save player original position

        // set player position
        position.x = 0.0f; // in units
        position.y = 0.0f; // ...

        // set player velocity
        velocity.x = 0.0f; // in units per second
        velocity.y = 0.0f; // ...
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        //Reading/processing input
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector2.up * speed * Time.deltaTime);
            velocity += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector2.down * speed * Time.deltaTime);
            velocity += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector2.left * speed * Time.deltaTime);
            velocity += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector2.right * speed * Time.deltaTime);
            velocity += Vector2.right;
        }

        // REALITY CHECK -- WE ARE IN UNITY

        // Apply friction
        // ...

        // Apply position
        position += velocity * acceleration * Time.deltaTime;
        transform.position = position;
    }
}
