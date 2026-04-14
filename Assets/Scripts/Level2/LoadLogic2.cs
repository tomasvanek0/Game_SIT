using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLogic2 : MonoBehaviour
{

    public static LoadLogic2 Instance;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public Level2 level2;
    public void LoadLogicGame()
    {
        Level2.Instance.LoadAnotherScene("Game1 - 2");
    }

    
}
