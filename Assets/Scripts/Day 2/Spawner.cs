using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;

    public float SpawnInterval = 3f;

    private float SinceLastSpawn = 0; 

    public float spawnBoundaryY = 5f;
    public float spawnBoundaryX = 10f;

    void Update()
    {
        SinceLastSpawn += Time.deltaTime;
        if (SinceLastSpawn >= SpawnInterval)
        {
            SpawnEnemy();
            SinceLastSpawn = 0;
        }
    }
    void SpawnEnemy()
    {
        if(EnemyPrefab == null)
        {
            Debug.Log("Prefab Enemy nggak ada, tambahin dulu wok");
            return;
        }
        float RandomY = Random.Range(-spawnBoundaryY, spawnBoundaryY);
        Vector3 spawnPosition = new Vector3(spawnBoundaryX, RandomY, 0);
        GameObject enemy = Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
    }
}