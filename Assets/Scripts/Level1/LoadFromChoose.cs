using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFromChoose : MonoBehaviour
{
    public void StartGame(string load)
    {
        SceneManager.LoadScene(load);
    }

}