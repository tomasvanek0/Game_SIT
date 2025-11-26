using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject prefabToSpawn;   
    public GameObject[] spawnPoints;
    private float speed;

    void Start()
    {
        SpawnAtRandomPoint();
        speed = Random.Range(1f, 5f);
    }

    void Update()
    {
        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
            SpawnAtRandomPoint();
        }
    }

    void SpawnAtRandomPoint()
    {
        

        int index = Random.Range(0, spawnPoints.Length);

        GameObject newObj = Instantiate(prefabToSpawn, spawnPoints[index].position, Quaternion.identity);

        
    }
}
