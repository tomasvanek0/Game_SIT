using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader1 : MonoBehaviour
{
    public float time;
    public GameObject FinalMenu;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start SceneLoader1: ");
        time = Random.Range(20, 40);
        
        StartCoroutine(AfterTime());

        
    }
    IEnumerator AfterTime()
    {
        if (Level1.Instance == null)
        {
            Debug.LogError("Level1.Instance je NULL!");
            yield break;
        }


        yield return new WaitForSeconds(time); 
        if (Level1.Instance.SceneCounter > 6)
        {
            Time.timeScale = 0f;
            Instantiate(FinalMenu);
            Debug.LogWarning("Hra zastavena z duvodu prekroceni limitu scén");
        }
        else
        {
            Debug.LogWarning("Hra pokracuje");
            Level1.Instance.LoadAnotherScene("LogicalGame - 1");
            Seats.Instance.gameObject.SetActive(true);
        }
        
    }

    

}
