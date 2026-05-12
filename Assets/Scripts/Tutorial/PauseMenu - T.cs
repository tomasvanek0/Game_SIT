using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenuT : MonoBehaviour
{
    public Exit exit;
    public GameObject spawnMenu;

    public void ContinueGame()
    {   
        Time.timeScale = 1f;
        Destroy(spawnMenu);
        Debug.Log("pauza klik");

    }

    public void ExitScene()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;

    }

}
