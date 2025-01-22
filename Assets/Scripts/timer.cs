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
    [SerializeField] private Transform startingPosition;
    [SerializeField] private Rigidbody PlayerRB;

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
        if (timeLeft < 1) 
        { 
            if (livesLeft != 0)
            {
                livesLeft --;
                ResetTimer();
                livesText.text = $"Lives: {livesLeft}";
                PlayerRB.position = startingPosition.position;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

    }

    public void ResetTimer()
    {
        timeLeft = startTime;
        timerText.text = $"Time: {timeLeft}";
    }



}
