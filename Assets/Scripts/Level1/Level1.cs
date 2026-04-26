using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public string ActualScene1;
    public int SceneCounter = 0;

    public static Level1 Instance;
    void Awake()
    {
        if (FindObjectsOfType<Level1>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    
    public void LoadAnotherScene(string LoadingScene)
    {
        SceneCounter++;
        SceneManager.LoadScene(LoadingScene);
        
    }

    


}
