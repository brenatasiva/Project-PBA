using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Finish : MonoBehaviour
{
    public ParticleSystem confetti;
    public Rigidbody ball;
    bool finish = true;
    public GameObject textCong;
    public GameObject textTime;
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
                textTime.SetActive(false);
                textCong.SetActive(true);
                ball.isKinematic = true;
                confetti.Play();
            }
        }
    }
}
