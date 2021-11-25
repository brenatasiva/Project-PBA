using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f;
    public float speedLimit = 20.0f;
    public TMP_Text textItemLeft;
    int itemLeft;

    // Start is called before the first frame update
    void Start()
    {
        itemLeft = int.Parse(textItemLeft.text);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (rb.velocity.magnitude <= speedLimit)
        {
            float forwardInput = Input.GetAxis("Vertical");
            rb.AddForce(Vector3.forward * forwardInput * speed);

            float sideInput = Input.GetAxis("Horizontal");
            rb.AddForce(Vector3.right * sideInput * speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Items(Clone)")
        {
            itemLeft -= 1;
            textItemLeft.text = itemLeft.ToString();
        }
    }
}
