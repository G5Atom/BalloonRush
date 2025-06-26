using UnityEngine;

public class HazardSpawner : MonoBehaviour
{
    public GameObject hazardPrefab;
    public Transform[] spawnPositions;
    public float spawnDelay = 2f;
    private float timeSinceLastSpawn = 0f;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnDelay) 
        {
            SpawnHazard();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnHazard() 
    {
       int randomIndex = Random.Range(0, spawnPositions.Length);

        Transform spawnPoint = spawnPositions[randomIndex];

        Instantiate(hazardPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
