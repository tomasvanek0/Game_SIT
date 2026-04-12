using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnT : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnTime;
    private float innerSpawnTime = 0;
    private SpawnPoints spawnPoints;

    public Transform[] spawnpoints;


    public Transform objectParrent;

    void Start()
    {
        spawnPoints = FindObjectOfType<SpawnPoints>();
    }

    void Update()
    {
        if (innerSpawnTime >= spawnTime)
        {
            SpawnObject();
            innerSpawnTime = 0;
        }

        innerSpawnTime += Time.deltaTime;
    }

    private void SpawnObject()
    {
        GameObject gameObjectFall = Instantiate(prefabToSpawn, GetRandomSpawnPoint());
        gameObjectFall.transform.SetParent(objectParrent);
        
    }

    public Transform GetRandomSpawnPoint()
    {
        return spawnpoints[UnityEngine.Random.Range(0, spawnpoints.Length)];
    }



}
