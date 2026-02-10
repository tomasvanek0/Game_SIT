using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit : MonoBehaviour
{
    public bool pause;
    public GameObject prefab;
    public GameObject spawnMenu;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (pause == false)
            {
                Time.timeScale = 0f;
                pause = true;
                spawnMenu = Instantiate(prefab);


            }
            else if (pause == true)
            {
                Time.timeScale = 1f;
                pause = false;
                Destroy(spawnMenu);
            }
        }
    }
}
