using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu2 : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void GoBackToMenu()
    {
        GameObject temp = new GameObject();
        DontDestroyOnLoad(temp);

        Scene ddolScene = temp.scene;

        foreach (GameObject obj in ddolScene.GetRootGameObjects())
        {
            Destroy(obj);
        }

        Time.timeScale = 1.0f;
        JsonScore.Instance.SaveGame2();
        SceneManager.LoadScene("Menu");
    }
    
      
    
}
