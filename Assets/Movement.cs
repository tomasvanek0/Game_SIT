using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Jakmile naraz� na jin� objekt s Box Colliderem, zastav� pohyb
        rb.velocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Kinematic;  // Aby u� d�l nepadal a neovliv�oval ho fyzika
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
