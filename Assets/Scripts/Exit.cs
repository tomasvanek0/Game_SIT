using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exit : MonoBehaviour
{
    public static Exit Instance { get; private set; }


    private GameObject spawnMenu;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Debug.Log("EXIT AWAE");
        Instance = this;
    }

    

    
}
