using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1f;
    private float sinceLastSpawn = 0;
    public float spawnBoundaryY = 4f;
    public float spawnBoundaryX = 10f;

    void Update()
    {
        sinceLastSpawn += Time.deltaTime;
        if(sinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            sinceLastSpawn = 0f;
        }
    }

    void SpawnEnemy()
    {
        if(enemyPrefab == null)
        {
            Debug.Log("Prefab is null!");
            return;
        }
        float randomY = Random.Range(-spawnBoundaryY, spawnBoundaryY);
        Vector3 spawnPosition = new Vector3(spawnBoundaryX, randomY, 0);
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    
}