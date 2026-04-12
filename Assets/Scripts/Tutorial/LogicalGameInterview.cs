using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicalGameInterview : MonoBehaviour
{

    public TMP_Text dialogue;
    public int dialoguePocet = 14;
    public int dialogueNumber = 0;
    public string[] monologs;
    public GameObject dialogueBar;

    // Start is called before the first frame update
    void Start()
    {
        dialogueNumber = 0;
        Time.timeScale = 0;
        dialogue.text = "Pro zahájení konverzace stiskni mezerník";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
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



        }

    }
}
