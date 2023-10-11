using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Vector3 direction= new Vector3(0, 0, 0);
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    private int turnFlag = 1;

    public void RestartBall()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
        turnFlag *= -1;
        direction = new Vector3(UnityEngine.Random.Range(0.5f, 1f) * turnFlag, UnityEngine.Random.Range(0.5f, 1f)* (UnityEngine.Random.Range(0, 2) * 2 - 1), 0);

    }

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(UnityEngine.Random.Range(0.5f, 1f), UnityEngine.Random.Range(-0.5f, -0.5f), 0);

    }

// Update is called once per frame
void Update()
    {
        gameObject.transform.position += new Vector3(xSpeed * Time.deltaTime * direction.x, ySpeed * Time.deltaTime * direction.y, direction.z * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //rigidbody.velocity = Vector3.Reflect(rigidbody.velocity, collision.contacts[0].normal);
        Vector3 normal = collision.contacts[0].normal;
        direction = Vector3.Reflect(direction, normal);
    }
}