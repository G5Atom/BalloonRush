using UnityEditor.Animations;
using UnityEngine;

public class HazardSpawner : MonoBehaviour
{
    public GameObject BirdPrefab1;
    public Transform[] spawnPositions1;
    public float spawnDelay1 = 2f;
    private float timeSinceLastSpawn1 = 0f;

    public GameObject PlanePrefab2;
    public Transform[] spawnPositions2;
    public float spawnDelay2;
    private float timeSinceLastSpawn2 = 0f;


    private void Update()
    {
        timeSinceLastSpawn1 += Time.deltaTime;

        if (timeSinceLastSpawn1 >= spawnDelay1) 
        {
            SpawnHazard();
            timeSinceLastSpawn1 = 0f;
        }

        timeSinceLastSpawn2 += Time.deltaTime;

        if (timeSinceLastSpawn2 >= spawnDelay2) 
        {
            SpawnHazard2();
            timeSinceLastSpawn2 = 0f;
        }
    }

    void SpawnHazard() 
    {
       int randomIndex = Random.Range(0, spawnPositions1.Length);

        Transform spawnPoint = spawnPositions1[randomIndex];

        Instantiate(BirdPrefab1, spawnPoint.position, spawnPoint.rotation);
    }

    void SpawnHazard2() 
    {
        int randomIndex = Random.Range(0, spawnPositions2.Length);

        Transform spawnPoint = spawnPositions2[randomIndex];

        Instantiate(PlanePrefab2, spawnPoint.position, spawnPoint.rotation);
    }
}
