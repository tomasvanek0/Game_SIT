using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class TutorialInterview : MonoBehaviour
{

    public TMP_Text dialogue;
    public int dialoguePocet = 7;
    public int dialogueNumber = 0;
    public string[] monologs;

   void Start()
    {
        dialogueNumber = 0;

        dialogue.text = "Pro zahájení konverzace stiskni mezerník";
  
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
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
            SceneManager.LoadScene("LogicalGame-Tut");
            dialogueNumber = 0;

        }
        
    }
   
}
