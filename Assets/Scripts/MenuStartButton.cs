using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartButton : MonoBehaviour
{
    
    public GameObject LevelSelector;
    public GameObject uvodniMenu;
    public GameObject controls;
    GameManager gameManager;

 

    public void StartGame()
    {
        Instantiate(LevelSelector);
        Destroy(uvodniMenu);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Tutorial(string Scene1)
    {
        SceneManager.LoadScene(Scene1);
    }

    public void ExitLevelSelector()
    {
        Destroy(LevelSelector);
        Instantiate(uvodniMenu);
        
    }
    public void StartFullGame(string load)
    {
        SceneManager.LoadScene(load);
    }

    public void Controls()
    {
        Instantiate(controls);
        Destroy(uvodniMenu );
    }

    public void ExitControls()
    {
        Destroy(controls);
        Instantiate(uvodniMenu);
    }
}
