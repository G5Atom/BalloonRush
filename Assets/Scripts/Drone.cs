//using UnityEngine;

//public class Drone : MonoBehaviour
//{
//    public GameObject DronePrefab;
//    public Transform[] spawnPositions1;
//    public float spawnDelay = 2f;
//    private float timeSinceLastSpawn1 = 0f;

//    private void Update()
//    {
//        timeSinceLastSpawn1 += Time.deltaTime;

//        if (timeSinceLastSpawn1 >= spawnDelay)
//        {
//            SpawnHazard();
//            timeSinceLastSpawn1 = 0f;
//        }
//    }

//    void SpawnHazard()
//    {
//        int randomIndex = Random.Range(0, spawnPositions1.Length);

//        Transform spawnPoint = spawnPositions1[randomIndex];

//        Instantiate(DronePrefab, spawnPoint.position, spawnPoint.rotation);
//    }


//}


