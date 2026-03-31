using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class SceneLoaderT : MonoBehaviour
{
    public float time;

    public TMP_Text dialogue;
    public GameManager gameManager;
    public string[] monologs2;
    public int dialogueNumberkonv2 = 0;
    public int dialoguePocetkonv2 = 3;
    public GameObject dialogueBar;
    public GameObject secondDialogue;

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(5, 10);
        StartCoroutine(AfterTime());
    }
    IEnumerator AfterTime()
    {
        yield return new WaitForSeconds(time); // 5 sekund
        SceneManager.LoadScene("Menu");
        GameManager.Instance.RemoveScore();


    }


    



}
