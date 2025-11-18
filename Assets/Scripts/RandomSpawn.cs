using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnTime;
    private float innerSpawnTime = 0;
    private SpawnPoints spawnPoints;

    public Transform enemyParrent;

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
        GameObject gameObjectFall = Instantiate(prefabToSpawn, spawnPoints.GetRandomSpawnPoint());
        gameObjectFall.transform.SetParent(enemyParrent);
        
    }

    

}
