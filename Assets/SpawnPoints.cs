using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public Transform[] spawnpoints;


    public Transform GetRandomSpawnPoint()
    {
        return spawnpoints[Random.Range(0, spawnpoints.Length)];
    }
}
