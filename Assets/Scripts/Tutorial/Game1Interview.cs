using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game1Interview : MonoBehaviour
{
    public TMP_Text dialogue;
    public GameManager gameManager;
    public string[] monologs;
    public int dialogueNumber = 0;
    public int dialoguePocet = 6;
    public GameObject dialogueBar;

    // Start is called before the first frame update
    void Start()
    {
        dialogueNumber = 0;

        Time.timeScale = 0;
        dialogue.text = "Nyní ti ukážu, jak bude probíhat cesta na zastávky.";
    }                                                       

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            NextDialogue();
            dialogueNumber += 1;

        }


    }

    void NextDialogue()
    {
        if (dialogueNumber < dialoguePocet)
        {
            dialogue.text = monologs[dialogueNumber];
        }
        else
        {
            Time.timeScale = 1f;
            Destroy(dialogueBar);
            dialogueNumber = 0;

            

        }

    }
}



