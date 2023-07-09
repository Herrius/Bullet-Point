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
        if (score == 20)
        {
            mainCamera.orthographicSize = 7;
            turret.transform.localScale = new Vector2(0.3f, 0.3f);
            bulletPrefab.transform.localScale = new Vector2(0.17f, 0.09f);
            enemyPrefab.transform.localScale = new Vector2(0.20f, 0.20f);
        }

        if (score == 40)
        {
            mainCamera.orthographicSize = 9;
            turret.transform.localScale = new Vector2(0.4f, 0.4f);
            bulletPrefab.transform.localScale = new Vector2(0.19f, 0.11f);
            enemyPrefab.transform.localScale = new Vector2(0.28f, 0.28f);
        }
    }
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
    }
}
