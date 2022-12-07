using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [Header("Animators")]
    public Animator animator;
    public Animator iconAnimator;
    
    [Tooltip("UI elements to attatch to dialogue manager")]
    [Header("Dialogue Box Elements")]
    public Text nameText; //this is what we pull for the ui
    public Text dialogueText; //determines what shows up in the ui
    
    private Queue<string> sentences;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        nameText.text = dialogue.characterName;
        sentences.Clear();
        
        if(dialogue.hasIcon == true)
        {
            iconAnimator.SetBool("hasIcon", true);
        }
        else
        {
            iconAnimator.SetBool("hasIcon", false);
        }

        animator.SetBool("isOpen", true);

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
    }
}
