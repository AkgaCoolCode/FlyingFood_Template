using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;                               

public class timer : MonoBehaviour
{
    public static timer instance;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private int startTime;
    private int timeLeft;
    private int livesLeft;
    [SerializeField] private TMP_Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        timerText.text = $"Time: {startTime}";
        timeLeft = startTime;
        livesLeft = 3;
        livesText.text = $"Lives: {livesLeft}";
        InvokeRepeating("TimeCount", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void TimeCount()
    {
        timeLeft--;
        timerText.text = $"Time: {timeLeft}";
        if (timeLeft == 0) 
        { 
            if (livesLeft != 0)
            {
                livesLeft --;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                //change scene to end screen
            }
        }

    }

    public void ResetTimer()
    {
        timeLeft = startTime;
        timerText.text = $"Time: {timeLeft}";
    }



}
