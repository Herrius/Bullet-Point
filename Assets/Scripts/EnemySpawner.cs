using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 10f;

    private Camera mainCamera;
    private float spawnTimer;

    private void Start()
    {
        mainCamera = Camera.main;
        spawnTimer = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            SpawnEnemy();
            spawnTimer = spawnInterval;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition;
        if (Random.value < 0.5f)
        {
            // Spawn at the top or bottom edge of the camera view.
            spawnPosition = mainCamera.ViewportToWorldPoint(new Vector3(Random.value, Random.value < 0.5f ? 0 : 1, mainCamera.farClipPlane));
        }
        else
        {
            // Spawn at the left or right edge of the camera view.
            spawnPosition = mainCamera.ViewportToWorldPoint(new Vector3(Random.value < 0.5f ? 0 : 1, Random.value, mainCamera.farClipPlane));
        }
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
