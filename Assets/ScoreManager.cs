using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;
    public TextMeshProUGUI scoreText;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("Multiple instances of ScoreManager!");
        }
    }
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
    }
}
