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


    void Update()
    {
        Movement = Input.GetAxis("Horizontal");
        Vector2 pohyb = new Vector2(Movement * speed *  Time.deltaTime, 0);
        transform.Translate(pohyb);

        float currentX = transform.position.x;

        // Vypoèítáme novou pozici X, která nesmí být menší než minX a vìtší než maxX
        float clampedX = Mathf.Clamp(currentX, minX, maxX);

        // Pokud je aktuální pozice X mimo povolený rozsah, nastavíme ji zpìt na hranici.
        // Tím se pohyb zablokuje, dokud se nezaènete hýbat zpìt.
        transform.position = new Vector2(clampedX, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogWarning("náraz");
        Destroy(collision.gameObject);
        SceneManager.LoadScene("Menu");
    }
}
