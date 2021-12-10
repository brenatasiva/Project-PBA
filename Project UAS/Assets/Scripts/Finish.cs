using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public ParticleSystem confetti;
    public Rigidbody ball;
    bool finish = true;
    public GameObject textCong;
    // Start is called before the first frame update
    void Start()
    {
        confetti.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            if (finish == true)
            {
                textCong.SetActive(true);
                ball.isKinematic = true;
                confetti.Play();
            }
        }
    }
}
