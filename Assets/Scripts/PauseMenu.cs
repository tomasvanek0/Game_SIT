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
        Time.timeScale = 1f;
        exit.pause = false;
        Destroy(spawnMenu);
        Debug.Log("pauza klik");

    }

    public void ExitScene()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;

    }

}
