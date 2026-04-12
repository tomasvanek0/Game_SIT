using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartButton : MonoBehaviour
{
    public string Scene1;
    public GameObject LevelSelector;
    public GameObject uvodniMenu;
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void StartGame(string Scene1)
    {
        Instantiate(LevelSelector);
        uvodniMenu.SetActive(false);
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
        uvodniMenu.SetActive(true);
        
    }
}
