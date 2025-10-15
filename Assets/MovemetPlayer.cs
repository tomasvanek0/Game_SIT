using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemetPlayer : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float moveLR = Input.GetAxis("Horizontal");

        Vector2 move = new Vector2 (moveLR, 0);

        transform.Translate(move * speed * Time.deltaTime);
    }
}
