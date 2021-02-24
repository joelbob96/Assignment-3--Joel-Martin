using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float SpawnDelay = 0.3f;

    public GameObject car;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;

    void Update()
    {
        if(nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + SpawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
