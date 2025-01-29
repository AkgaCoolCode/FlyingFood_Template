using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;
    [SerializeField] private TMP_Text scoretext;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
        instance = this;
        scoretext.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScore(int amount)
    {
        score += amount;
        scoretext.text = $"Score: {score}";
    }
}
