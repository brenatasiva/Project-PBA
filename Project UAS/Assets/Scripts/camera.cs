using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float distance;
    public float height;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ballPos;

        ballPos = ball.transform.position;
        ballPos.x = ball.transform.position.x;
        ballPos.y += 15;
        ballPos.z += -13;

        transform.position = ballPos;
    }
}
