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
        var = new Vector3(2, 3, 0);

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
        colAngle = 180 - Vector3.Angle(var, -normal) ;
        Debug.Log(colAngle);
        var = new Vector3(var.x * Mathf.Cos(colAngle * Mathf.Deg2Rad), var.y * Mathf.Cos(colAngle * Mathf.Deg2Rad), 0);
        //var = Vector3.Reflect(this.transform.position, collision.contacts[0].normal);
        Debug.Log(colAngle);
        Debug.Log(var);

        Debug.Log(Mathf.Cos(90 *Mathf.Deg2Rad));
    }
}
