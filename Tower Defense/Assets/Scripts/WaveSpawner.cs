using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    public float timeBetweenEnemySpawn = 0.5f;//When we spawn more than one enemies.They spawn at the same location.To fix that we use this variable to spawn other enemy 0.5 seconds later.
    private float countDown = 2f;

    public TextMeshProUGUI waveCountdownText;

    private int waveIndex = 0;

    private void Update()
    {
        if (countDown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        }
        countDown -= Time.deltaTime;
        countDown = Mathf.Clamp(countDown, 0f, Mathf.Infinity);
        waveCountdownText.text = string.Format("{0:00.00}", countDown);
    }
    IEnumerator SpawnWave()
    {
        waveIndex++;
        PlayerStats.Rounds++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(timeBetweenEnemySpawn);//wait 0.5 seconds
        }
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
