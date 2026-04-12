using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader1 : MonoBehaviour
{

    public Level1 level1;
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
        if (Level1.Instance.SceneCounter > 6)
        {
            Time.timeScale = 0;
        }
        else
        {
            Level1.Instance.LoadAnotherScene("LogicalGame - 1");
        }
        
    }

    

}
