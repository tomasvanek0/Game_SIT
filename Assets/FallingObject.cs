using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float speed;
    private float RandomX;

    void Start()
    {
        RandomX = Random.Range(-10f, 10f);
        transform.position = new Vector2(RandomX, 6);
    }

    void Update()
    {

        if (transform.position.y < - 7)
        {
            RandomX = Random.Range(-10f, 10f);
            transform.position = new Vector2(RandomX, 6);
        }
    }

    private void falling()
    {
        
    }
    
}
