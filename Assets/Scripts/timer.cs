using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;                               

public class timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private int startTime;
    private int timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = $"Time: {startTime}";
        timeLeft = startTime;
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
        if (timeLeft < 0) 
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
