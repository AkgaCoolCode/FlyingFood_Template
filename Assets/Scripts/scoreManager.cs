using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoretext;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScore(int amount)
    {
        score += amount;
    }
}
