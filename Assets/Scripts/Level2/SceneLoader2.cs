using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader2 : MonoBehaviour
{

    public Level2 level2;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(20, 40);
        StartCoroutine(AfterTime());
    }
    IEnumerator AfterTime()
    {
        yield return new WaitForSeconds(time); 
        if (Level2.Instance.SceneCounter > 6)
        {
            Time.timeScale = 0;
        }
        else
        {
            Level2.Instance.LoadAnotherScene("LogicalGame - 1");
        }
        
    }

    

}
