using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopOnCollision : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Narazil jsem na: " + collision.gameObject.name);

        // Zastav pohyb
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;

        // Pøepni na Kinematic, aby objekt už dál nepadal a nezvládal fyziku
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
}
