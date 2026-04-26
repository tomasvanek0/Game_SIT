using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startmenu : MonoBehaviour
{
    public GameObject LevelSelector;
    public GameObject uvodniMenu;
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        Instantiate(uvodniMenu);
    }
}
