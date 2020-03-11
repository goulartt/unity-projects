using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    
    private Rigidbody2D rbd;
    public float velocity;
    private float width;
    private float height;

    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        velocity = 5;
        rbd.velocity = new Vector2(0, -velocity);



    }

    // Update is called once per frame
    void Update()
    {

    }
}
