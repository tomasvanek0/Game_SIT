using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class TutorialInterview : MonoBehaviour
{

    public TMP_Text dialogue;
    public int dialoguePocet = 5;
    public int dialogueNumber = 0;
    public string[] monologs;

   void Start()
    {
        
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
            dialogue.text = "Konec Dialogu";
            SceneManager.LoadScene("Game1 - Tut");

        }
        
    }
   
}
