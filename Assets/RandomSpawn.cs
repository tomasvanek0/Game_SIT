using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Transform[] spawnPoints;

    void Start()
    {
        SpawnAtRandomPoint();
    }

    void SpawnAtRandomPoint()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(prefabToSpawn, spawnPoints[index].position, Quaternion.identity);
    }

}
