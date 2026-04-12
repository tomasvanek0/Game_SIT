using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
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
        yield return new WaitForSeconds(time); // 5 sekund
        level1.LoadAnotherScene("LogicalGame");
    }

}
