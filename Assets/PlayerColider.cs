using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerColider : MonoBehaviour
{

    // Update is called once per frame
    private void Collision(Collision collision)
    {
        if (collision.gameObject.CompareTag("Auto"))
        {
            Debug.LogWarning("Náraz");
            Destroy(gameObject);

            SceneManager.LoadScene("Menu");
        }

        else { }
    }
}
