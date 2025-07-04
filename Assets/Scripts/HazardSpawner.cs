//using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;

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

    public GameObject DronePrefab;
    public Transform[] spawnPositions3;
    public float spawnDelay = 2f;
    private float timeSinceLastSpawn3 = 0f;

    public GameObject CloudPrefab;
    public Transform[] spawnPositions4;
    public float spawnDelay4 = 3f;
    private float timeSinceLastSpawn4 = 0f;


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

        timeSinceLastSpawn3 += Time.deltaTime;

        if (timeSinceLastSpawn3 >= spawnDelay)
        {
            SpawnHazard3();
            timeSinceLastSpawn3 = 0f;
        }

        timeSinceLastSpawn4 += Time.deltaTime;

        if (timeSinceLastSpawn4 >= spawnDelay)
        {
            SpawnHazard4();
            timeSinceLastSpawn4 = 0f;
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

    void SpawnHazard3()
    {
        int randomIndex = Random.Range(0, spawnPositions3.Length);

        Transform spawnPoint = spawnPositions3[randomIndex];

        Instantiate(DronePrefab, spawnPoint.position, spawnPoint.rotation);
    }

    void SpawnHazard4()
    {
        int randomIndex = Random.Range(0, spawnPositions4.Length);

        Transform spawnPoint = spawnPositions4[randomIndex];

        Instantiate(CloudPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
