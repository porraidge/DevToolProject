using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [Header("Animators")]
    public Animator dialogueBoxAnimatior;
    public Animator iconAnimator;
    

    [Header("Dialogue Box Elements")]
    [Tooltip("UI name text")]
    public Text nameText; 
    [Tooltip("UI dialogue text")]
    public Text dialogueText; 
    public Image iconImage;
    
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
            iconImage = dialogue.iconImage;
        }
        else
        {
            iconAnimator.SetBool("hasIcon", false);
        }

        dialogueBoxAnimatior.SetBool("isOpen", true);

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
        dialogueBoxAnimatior.SetBool("isOpen", false);
    }
}
