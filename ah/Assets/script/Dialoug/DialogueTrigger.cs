using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
    public GameObject canvas;

	public void TriggerDialogue ()
	{
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            canvas.SetActive(true);
	}
       // void OnCollisionEnter2D(Collision2D col)
       // {
            
       // }
	public void Update()
    {
        
       void OnCollisionEnter2D(Collision2D col)
       {
           TriggerDialogue();
       }
        
    }
      
}
