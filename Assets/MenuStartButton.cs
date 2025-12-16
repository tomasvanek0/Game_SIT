using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartButton : MonoBehaviour
{
    public string Scene1;

    public void StartGame(string Scene1)
    {
        SceneManager.LoadScene(Scene1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
