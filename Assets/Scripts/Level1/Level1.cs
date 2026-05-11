using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public string ActualScene1;
    public int SceneCounter;

    public static Level1 Instance;
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
