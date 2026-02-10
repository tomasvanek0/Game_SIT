using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public Exit exit;
    public GameObject spawnMenu;

    public void ContinueGame()
    {
        exit.pause = false;
        Time.timeScale = 1f;
        Destroy(spawnMenu);

    }

    public void ExitScene()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;

    }

}
