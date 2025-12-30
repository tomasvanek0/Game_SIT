using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    public float Health;

    void Update()
    {
        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
        }
    }

}
