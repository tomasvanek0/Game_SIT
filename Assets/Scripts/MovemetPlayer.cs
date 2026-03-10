using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovemetPlayer : MonoBehaviour
{
    public float speed;
    private float Movement;

    public float maxX;

    public float minX;

    private float timer;

    public GameManager gameManager;

    void Update()
    {
        Movement = Input.GetAxis("Horizontal");
        Vector2 pohyb = new Vector2(Movement * speed *  Time.deltaTime, 0);
        transform.Translate(pohyb);

        float currentX = transform.position.x;

        float clampedX = Mathf.Clamp(currentX, minX, maxX);

        transform.position = new Vector2(clampedX, transform.position.y);

        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer -= 1f;
            ScoreCount();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogWarning("náraz");
        Destroy(collision.gameObject);
        GameManager.Instance.AddScore(-500);

    }
    void ScoreCount()
    {
        GameManager.Instance.AddScore(100);
        Debug.Log(gameManager.score);

    }
}
