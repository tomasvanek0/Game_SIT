using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameManager gameManager;
    public TMP_Text scoreText;
   
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = GameManager.Instance.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       scoreText.text = GameManager.Instance.score.ToString();

    }

    
}
