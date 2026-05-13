using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject spawnMenu;
    public bool pause = false;

    [SerializeField] private GameObject prefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pause)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }



    public void ExitScene()
    {
        Time.timeScale = 1f;
        GameObject temp = new GameObject();
        DontDestroyOnLoad(temp);

        Scene ddolScene = temp.scene;

        foreach (GameObject obj in ddolScene.GetRootGameObjects())
        {
            Destroy(obj);
        }
        SceneManager.LoadScene("Menu");
    }


    public void PauseGame()
    {
        Time.timeScale = 0f;

        pause = true;

        spawnMenu = Instantiate(prefab);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;

        pause = false;



        Destroy(spawnMenu);

    }

}
