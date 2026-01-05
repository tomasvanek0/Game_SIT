using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public MovemetPlayer movemetPlayer;
    public TMP_Text scoreText;
   
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = movemetPlayer.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       scoreText.text = movemetPlayer.score.ToString();

    }

    
}
