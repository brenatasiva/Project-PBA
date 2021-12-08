using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject pusher;
    private bool dirRight = false;
    private bool stop = true;
    private float speed = 0.0f;

    private void Update()
    {
        if (stop == false)
        {
            if (dirRight)
            {
                speed = 10.0f;
                pusher.transform.Translate(Vector2.right * speed * Time.deltaTime);
            }

            else
            {
                speed = 2.0f;
                pusher.transform.Translate(-Vector2.right * speed * Time.deltaTime);
            }

            if (pusher.transform.position.x >= 41)
            {
                dirRight = false;
            }

            if (pusher.transform.position.x <= 35)
            {
                dirRight = true;
            }
        }
        else
        {
            if (pusher.transform.position.x <= 39)
            {
                speed = 2.0f;
                pusher.transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else if (pusher.transform.position.x >= 39.1)
            {
                speed = 2.0f;
                pusher.transform.Translate(-Vector2.right * speed * Time.deltaTime);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        stop = false;
    }

    private void OnTriggerExit(Collider other)
    {
        stop = true;
        
    }
}
