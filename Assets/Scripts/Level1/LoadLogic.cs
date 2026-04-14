using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLogic : MonoBehaviour
{

    public static LoadLogic Instance;

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

    public Level1 level1;
    public void LoadLogicGame()
    {
        Level1.Instance.LoadAnotherScene("Game1 - 1");
    }

    
}
