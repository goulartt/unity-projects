using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rbd;
    public float velocity;
    private float width;
    private float height;

    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        velocity = 10;
        height = Camera.main.orthographicSize;
        width = height * Camera.main.aspect;


    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x, y) * velocity;

        if (transform.position.x > width)
            transform.position = new Vector2(-width, transform.position.y);
        else if (transform.position.x < -width)
            transform.position = new Vector2(width, transform.position.y);

        if (transform.position.y > 0)
            transform.position = new Vector2(transform.position.x, 0);

        if (transform.position.y < -height)
            transform.position = new Vector2(transform.position.x, -height);

    }
}
