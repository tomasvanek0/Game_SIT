using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit : MonoBehaviour
{
    public PauseMenu pauseMenu;
    public bool pause = false;
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
                Debug.Log("pauza esc");


            }
            else if (pause == true)
            {
                pauseMenu.ContinueGame();
            }
        }
    }
}
