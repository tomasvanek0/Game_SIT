using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private float speed;
    private GameManager gameManager;
    private float RandomX;
    Rigidbody rb;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        speed = Random.Range(1f, 5f);
        RandomX = Random.Range(-10f, 10f);
        transform.position = new Vector2(RandomX, 6);

        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void Update()
    {

        //falling();
        
    }

    private void falling()
    {
        transform.Translate(new Vector2(0, -10f) * speed * Time.deltaTime);
        if (transform.position.y < -7f)
        {
            gameManager.CreateCircle();
            Destroy(gameObject);

        }

    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(2, -speed * Time.fixedDeltaTime);
        rb.MovePosition(movement);
    }

}
