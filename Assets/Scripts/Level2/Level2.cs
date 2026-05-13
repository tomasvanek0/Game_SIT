using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public string ActualScene1;
    public int SceneCounter;

    public static Level2 Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }



    public void LoadAnotherScene(string LoadingScene)
    {
        
        SceneManager.LoadScene(LoadingScene);

    }
}
