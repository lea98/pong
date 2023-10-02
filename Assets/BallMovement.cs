using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Vector3 var;
    public float colAngle;

    // Start is called before the first frame update
    void Start()
    {
        var = new Vector3(4, 1, 0);

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(var.x * Time.deltaTime, var.y * Time.deltaTime, var.z * Time.deltaTime) ;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //rigidbody.velocity = Vector3.Reflect(rigidbody.velocity, collision.contacts[0].normal);
        Vector3 normal = collision.contacts[0].normal;
        if (Math.Abs(normal.x) > Math.Abs(normal.y))
        {
            var = new Vector3(-var.x, var.y, 0);
        }
        if (Math.Abs(normal.x) < Math.Abs(normal.y))
        {
            var = new Vector3(var.x, -var.y, 0);

        }
    }
}
