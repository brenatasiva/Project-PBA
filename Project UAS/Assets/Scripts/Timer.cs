using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text textTime;
    public TMP_Text textCollected;
    float timer;
    bool startGame = false;
    int collectedItem;
    // Start is called before the first frame update
    void Start()
    {
        timer = 60;
        startGame = true;
        collectedItem = int.Parse(textCollected.text);
    }

    // Update is called once per frame
    void Update()
    {
        collectedItem = int.Parse(textCollected.text);
        if (startGame)
        {
            if (timer > 0)
            {
                if(collectedItem > 0)
                {
                    timer -= Time.deltaTime;
                    float timerRound = Mathf.Floor(timer);
                    textTime.text = "Sisa waktu : " + timerRound.ToString();
                }
                else
                {
                    SceneManager.LoadScene("Level2");
                }
            }
            else
            {
                timer = 0;
                textTime.text = "Waktu HABIS!";
                startGame = false;
            }            
        }
        else
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
