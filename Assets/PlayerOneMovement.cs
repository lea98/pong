using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") ){
            gameObject.transform.position += new Vector3(0, 4f * Time.deltaTime, 0);

        }

        if (Input.GetKey("s"))
        {
            gameObject.transform.position += new Vector3(0, -4f * Time.deltaTime, 0);

        }
    }
}
