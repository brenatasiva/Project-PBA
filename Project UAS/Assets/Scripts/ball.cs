using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f;
    public float speedLimit = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude <= speedLimit)
        {
            float forwardInput = Input.GetAxis("Vertical");
            rb.AddForce(Vector3.forward * forwardInput * speed);

            float sideInput = Input.GetAxis("Horizontal");
            rb.AddForce(Vector3.right * sideInput * speed);
        }
    }
}
