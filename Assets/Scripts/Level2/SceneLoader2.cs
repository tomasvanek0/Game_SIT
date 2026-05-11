using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader2 : MonoBehaviour
{
    public GameObject FinalMenu;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start SceneLoader1: ");
        time = Random.Range(20, 40);
        StartCoroutine(AfterTime());
    }
    IEnumerator AfterTime()
    {
        if (Level2.Instance == null)
        {
            Debug.LogError("Level1.Instance je NULL!");
            yield break;
        }

        yield return new WaitForSeconds(time); 
        if (Level2.Instance.SceneCounter > 10)
        {
            Debug.LogWarning("Hra zastavena z duvodu prekroceni limitu scén");
            Instantiate(FinalMenu);
            Time.timeScale = 0f;
        }
        else
        {
            Debug.LogWarning("Hra pokracuje");
            Level2.Instance.LoadAnotherScene("LogicalGame - 2");
            Seats.Instance.gameObject.SetActive(true);
        }
        
    }

    

}
