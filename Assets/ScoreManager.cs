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
    public Camera mainCamera;
    public GameObject turret;
    public GameObject bulletPrefab;
    public GameObject enemyPrefab;

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
        float scale = score / 500.0f; // Declara y calcula la escala fuera del condicional
        if (score >= 20)
        {
            mainCamera.orthographicSize = 5+ scale;
            turret.transform.localScale = new Vector2(0.2f + scale, 0.2f + scale);
            bulletPrefab.transform.localScale = new Vector2(0.15f + scale, 0.075f + scale);
            enemyPrefab.transform.localScale = new Vector2(0.12f + scale, 0.11f + scale);
        }

    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
    }
}
